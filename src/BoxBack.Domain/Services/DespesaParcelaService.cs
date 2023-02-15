using AutoMapper;
using Microsoft.Extensions.Logging;
using BoxBack.Domain.Interfaces;
using System.Threading.Tasks;
using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;
using BoxBack.Domain.ServicesValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxBack.Domain.Services
{
    public class DespesaParcelaService : IDespesaParcelaService
    {
        private readonly ILogger _logger;
        private readonly IDespesaParcelaRepository _despesaParcelaRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        
        public DespesaParcelaService(ILogger<ClienteService> logger,
                                     IDespesaParcelaRepository despesaParcelaRepository,
                                     IMapper mapper,
                                     IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _despesaParcelaRepository = despesaParcelaRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddRangeWhithoutCommitAsync(IEnumerable<DespesaParcela> despesaParcelas)
        {
            #region Entity validations
            var despesaParcelaValidator = new DespesaParcelaValidator();
            for (var i = 0; i < despesaParcelas.Count(); i++)
            {
                despesaParcelaValidator.ValidateAndThrow(despesaParcelas.ToArray()[i]);
            }
            #endregion

            #region Persistance
            try
            {
                await _despesaParcelaRepository.AddRangeAsync(despesaParcelas.ToList());
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
                throw new Exception($"Erro ao tentar adicionar uma parcela da despesa: {ex.Message}", ex);
            }
            #endregion
        }

        public void Dispose()
        {
            _despesaParcelaRepository.Dispose();
        }
    }
}