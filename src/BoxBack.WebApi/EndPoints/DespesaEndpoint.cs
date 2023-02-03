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
        /// Lista de todas as DESPESAS
        /// </summary>
        /// <param name="q"></param>
        /// <returns>Um json com as DESPESAS</returns>
        /// <response code="200">Lista de DESPESAS</response>
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
        public async Task<IActionResult> ListAsync(string q)
        {
            #region Get data
            var despesas = new List<Despesa>();
            try
            {
                despesas = await _context.Despesas
                                            .AsNoTracking()
                                            .Include(x => x.Cliente)
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
                despesas = despesas.Where(x => x.Cliente.NomeFantasia.ToLower().Contains(q.ToLower())).ToList();
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
                Despesas = despesasMapped.ToList(),
                Params = q,
                Total = despesasMapped.Count()
            });
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
        [Route("list-by-clienteId")]
        [HttpGet]
        public async Task<IActionResult> ListByClienteIdAsync(string q, Guid clienteId)
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

        /// <summary>
        /// Atualiza uma DESPESA de um cliente
        /// </summary>
        /// <param name="despesaViewModel"></param>
        /// <returns>True se atualizada com sucesso</returns>
        /// <response code="204">Atualizada com sucesso</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="500">Erro desconhecido</response>
        [Authorize(Roles = "Master, CanDespesaUpdate, CanDespesaAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Route("update")]
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody]DespesaViewModel despesaViewModel)
        {
            #region Required validations
            if (!despesaViewModel.Id.HasValue ||
                despesaViewModel.Id == Guid.Empty)
            {
                AddError("Id requerido.");
                return CustomResponse(400);
            }
            #endregion

            #region Get data for update
            var despesaDB = new Despesa();
            try
            {
                despesaDB = await _context
                                        .Despesas
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id.Equals(despesaViewModel.Id));
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }

            if (despesaDB == null)
            {
                AddError("Despesa do cliente não encontrada para atualizar.");
                return CustomResponse(404);
            }
            #endregion

            #region Map
            var despesaMap = new Despesa();
            try
            {
                despesaMap = _mapper.Map<DespesaViewModel, Despesa>(despesaViewModel, despesaDB);
                despesaMap.Cliente = null;
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            #region Update despesa cliente
            try
            {
                _context.Despesas.Update(despesaMap);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion
            
            #region Check to result
            try
            {
                await _unitOfWork.CommitAsync(); 
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            return CustomResponse(200, new { clienteId = despesaViewModel.ClienteId } );
        }

        /// <summary>
        /// Altera o status de uma DESPESA de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True se a operação foi realizada com sucesso</returns>
        /// <response code="200">Status alterado com sucesso</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Erro interno desconhecido</response>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /alter-status
        ///     {
        ///        "id": "f9c7d5a6-1181-4591-948b-5f97088e20a4"
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Master, CanDespesaUpdate, CanDespesaAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Route("alter-status/{id}")]
        [HttpPut]
        public async Task<IActionResult> AlterStatusAsync(Guid id)
        {
            #region Validations required
            if (id == Guid.Empty)
            {
                AddError("Id requerido.");
                return CustomResponse(400);
            }
            #endregion
    
            #region Get data
            var despesa = new Despesa();
            try
            {
                despesa = await _context.Despesas.FindAsync(id);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            
            if (despesa == null)
            {
                AddError("Despesa do cliente não encontrada para alterar seu status.");
                return CustomResponse(404);
            }
            #endregion

            #region Map
            switch(despesa.IsDeleted)
            {
                case true:
                    despesa.IsDeleted = false;
                    break;
                case false:
                    despesa.IsDeleted = true;
                    break;
            }
            #endregion

            #region Alter status
            try
            {
                _context.Despesas.Update(despesa);
                _unitOfWork.Commit();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            return CustomResponse(200, new { message = "Status da despesa do cliente alterado com sucesso.", clienteId = despesa.ClienteId } );
        }
    }
}