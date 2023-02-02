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