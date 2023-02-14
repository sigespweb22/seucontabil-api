using AutoMapper;
using Microsoft.Extensions.Logging;
using BoxBack.Domain.Interfaces;
using System.Threading.Tasks;
using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;
using BoxBack.Domain.ServicesValidators;
using FluentValidation;
using System;

namespace BoxBack.Domain.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly ILogger _logger;
        private readonly IDespesaRepository _despesaRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        
        public DespesaService(ILogger<ClienteService> logger,
                              IDespesaRepository despesaRepository,
                              IMapper mapper,
                              IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _despesaRepository = despesaRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(Despesa despesa)
        {
            #region Entity validations
            var despesaValidator = new DespesaValidator();
            despesaValidator.ValidateAndThrow(despesa);
            #endregion

            #region Persistance
            try
            {
                await _despesaRepository.AddAsync(despesa);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw new Exception($"Erro ao tentar adicionar uma despesa: {ex.Message}", ex);
            }
            #endregion

            #region Commit
            try
            {
                return await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw new Exception($"Erro ao tentar adicionar uma despesa: {ex.Message}", ex);
            }
            #endregion
        }
    
        public void Dispose()
        {
            _despesaRepository.Dispose();
        }
    }
}