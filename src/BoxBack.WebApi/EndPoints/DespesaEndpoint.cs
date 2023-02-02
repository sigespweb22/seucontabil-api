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
using BoxBack.Domain.InterfacesRepositories;
using BoxBack.WebApi.Controllers;
using BoxBack.Application.ViewModels.Selects;
using BoxBack.Domain.Enums;
using BoxBack.WebApi.Helpers;

namespace BoxBack.WebApi.EndPoints
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/despesas")]
    public class DespesaEndpoint : ApiController
    {
        private readonly BoxAppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DespesaEndpoint(BoxAppDbContext context,
                               IUnitOfWork unitOfWork,
                               IMapper mapper)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Lista de todas as DESPESAS de um cliente
        /// </summary>
        /// <param name="q"></param>
        /// <param name="clienteId"></param>
        /// <returns>Um json com as DESPESAS de um cliente</returns>
        /// <response code="200">Lista de DESPESAS do cliente</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="404">Lista vazia</response>
        /// <response code="500">Erro desconhecido</response>
        [Authorize(Roles = "Master, CanDespesaList, CanDespesaAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Route("list")]
        [HttpGet]
        public async Task<IActionResult> ListAsync(string q, Guid clienteId)
        {
            if (clienteId.Equals(Guid.Empty))
            {
                AddError("Id Cliente requerido.");
                return CustomResponse(400);
            }

            #region Get data
            var despesas = new List<Despesa>();
            try
            {
                despesas = await _context.Despesas
                                            .AsNoTracking()
                                            .Include(x => x.Cliente)
                                            .Where(x => x.ClienteId.Equals(clienteId))
                                            .OrderByDescending(x => x.UpdatedAt)
                                            .ToListAsync();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }

            if (despesas == null)
            {
                AddError("Não encontrado.");
                return CustomResponse(404);
            }
            #endregion
            
            #region Filter search 
            if(!string.IsNullOrEmpty(q))
                despesas = despesas.Where(x => x.ValorPrincipal.Equals(q)).ToList();
            #endregion

            #region Map
            IEnumerable<DespesaViewModel> despesasMapped = new List<DespesaViewModel>();
            try
            {
                despesasMapped = _mapper.Map<IEnumerable<DespesaViewModel>>(despesas);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion
            
            return Ok(new {
                AllData = despesasMapped.ToList(),
                clienteProdutos = despesasMapped.ToList(),
                Params = q,
                Total = despesasMapped.Count()
            });
        }

        /// <summary>
        /// Cria uma despesa para um cliente
        /// </summary>
        /// <param name="despesaViewModel"></param>
        /// <returns>True se adicionardo com sucesso</returns>
        /// <response code="201">Criado com sucesso</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        [Authorize(Roles = "Master, CanDespesaCreate, CanDespesaAll")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody]DespesaViewModel despesaViewModel)
        {
            #region Map
            var despesaMapped = new Despesa();
            try
            {
                despesaMapped = _mapper.Map<Despesa>(despesaViewModel);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            #region Persistance and commit
            try
            {
                await _context.Despesas.AddAsync(despesaMapped);
                _unitOfWork.Commit();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            return CustomResponse(201);
        }
    }
}