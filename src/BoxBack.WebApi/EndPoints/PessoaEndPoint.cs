using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoxBack.Infra.Data.Context;
using BoxBack.Domain.Models;
using AutoMapper;
using BoxBack.Domain.InterfacesRepository;
using BoxBack.WebApi.Controllers;
using BoxBack.Application.ViewModels.Selects;

namespace BoxBack.WebApi.EndPoints
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/pessoas")]
    public class PessoaEndPoint : ApiController
    {
        private readonly BoxAppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PessoaEndPoint(BoxAppDbContext context,
                               IUnitOfWork unitOfWork,
                               IMapper mapper)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Lista todas as PESSOAS pela sua NATUREZA
        /// </summary>
        /// <param name="naturezaPessoa"></param>
        /// <param name="isDeleted"></param>
        /// <returns>Um json com as PESSOAS</returns>
        /// <response code="200">Lista de PESSOAS</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="404">Lista vazia</response>
        /// <response code="500">Erro desconhecido</response>
        [Authorize(Roles = "Master, CanPessoaList, CanPessoaAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("list-to-select/")] 
        [HttpGet]
        public async Task<IActionResult> ListToSelectAsync(string naturezaPessoa, bool isDeleted = false)
        {
            #region Validations
            if (string.IsNullOrEmpty(naturezaPessoa))
            {
                throw new ArgumentNullException(nameof(naturezaPessoa));
            }
            #endregion

            #region Get data
            var pessoasDB = new List<Pessoa>();
            try
            {
                pessoasDB = await _context
                                        .Pessoas
                                        .Where(x => !x.IsDeleted || x.IsDeleted == isDeleted &&
                                                x.NaturezaPessoa.Equals(naturezaPessoa))
                                        .ToListAsync();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            
            if (pessoasDB == null || pessoasDB.Count == 0)
            {
                AddError("Não encontrado");
                return CustomResponse(404);
            }
            #endregion
            
            #region Map
            IEnumerable<PessoaSelect2ViewModel> pessoasMap = new List<PessoaSelect2ViewModel>();
            try
            {
                pessoasMap = _mapper.Map<IEnumerable<PessoaSelect2ViewModel>>(pessoasDB);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion
            
            return Ok(pessoasMap);
        }
    }
}