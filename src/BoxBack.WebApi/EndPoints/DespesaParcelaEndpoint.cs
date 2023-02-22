using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoxBack.Infra.Data.Context;
using BoxBack.Application.ViewModels;
using BoxBack.Domain.Models;
using AutoMapper;
using BoxBack.Application.Interfaces;
using BoxBack.WebApi.Controllers;
using BoxBack.Domain.InterfacesRepository;
using Microsoft.Extensions.Logging;

namespace BoxBack.WebApi.EndPoints
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/despesas-parcelas")]
    public class DespesaParcelaEndpoint : ApiController
    {
        private readonly BoxAppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IDespesaParcelaAppService _despesaParcelaAppService;
        private readonly ILogger<DespesaParcelaEndpoint> _logger;

        public DespesaParcelaEndpoint(BoxAppDbContext context,
                                      IUnitOfWork unitOfWork,
                                      IMapper mapper,
                                      IDespesaParcelaAppService despesaParcelaAppService,
                                      ILogger<DespesaParcelaEndpoint> logger)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _despesaParcelaAppService = despesaParcelaAppService;
            _logger = logger;
        }

        /// <summary>
        /// Lista de todas as PARCELAS de uma DESPESA
        /// </summary>
        /// <param name="q"></param>
        /// <param name="despesaId"></param>
        /// <returns>Um json com as PARCELAS de uma DESPESAS</returns>
        /// <response code="200">Lista de PARCELAS de uma DESPESA</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="404">Lista vazia</response>
        /// <response code="500">Erro desconhecido</response>
        [Authorize(Roles = "Master, CanDespesaParcelaList, CanDespesaParcelaAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Route("list-by-despesaId")]
        [HttpGet]
        public async Task<IActionResult> ListByDespesaIdAsync(string q, Guid despesaId)
        {
            if (despesaId.Equals(Guid.Empty))
            {
                AddError("Id da despesa requerido.");

                _logger.LogError("Id da despesa requerido.");
                return CustomResponse(400);
            }

            #region Get data
            var despesaParcelas = new List<DespesaParcela>();
            try
            {
                despesaParcelas = await _context.DespesasParcelas
                                                    .AsNoTracking()
                                                    .Include(x => x.Despesa)
                                                    .Where(x => x.DespesaId.Equals(despesaId))
                                                    .OrderByDescending(x => x.UpdatedAt)
                                                    .ToListAsync();
            }
            catch (Exception ex) { 
                AddErrorToTryCatch(ex);
                
                _logger.LogError("Id da despesa requerido.");
                return CustomResponse(500); 
            }

            if (despesaParcelas == null)
            {
                AddError("Não encontrado.");

                _logger.LogError("Não encontrado.");
                return CustomResponse(404);
            }
            #endregion
            
            #region Filter search 
            if(!string.IsNullOrEmpty(q))
                despesaParcelas = despesaParcelas.Where(x => x.Despesa.ValorPrincipal.Equals(q)).ToList();
            #endregion

            #region Map
            IEnumerable<DespesaParcelaViewModel> despesaParcelasMapped = new List<DespesaParcelaViewModel>();
            try
            {
                despesaParcelasMapped = _mapper.Map<IEnumerable<DespesaParcelaViewModel>>(despesaParcelas);
            }
            catch (Exception ex) { 
                AddErrorToTryCatch(ex);
                
                _logger.LogError("Não encontrado.");
                return CustomResponse(500); 
            }
            #endregion
            
            return Ok(new {
                AllData = despesaParcelasMapped.ToList(),
                despesaParcelas = despesaParcelasMapped.ToList(),
                Params = q,
                Total = despesaParcelasMapped.Count()
            });
        }
    }
}