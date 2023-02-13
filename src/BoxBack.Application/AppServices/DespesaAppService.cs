using System;
using System.Threading.Tasks;
using AutoMapper;
using BoxBack.Application.Interfaces;
using BoxBack.Application.ViewModels;
using BoxBack.Domain.Interfaces;
using BoxBack.Domain.Models;
using Microsoft.Extensions.Logging;

namespace BoxBack.Application.AppServices
{
    public class DespesaAppService : IDespesaAppService
    {
        private readonly ILogger _logger;
        private readonly IDespesaService _despesaService;
        private readonly IMapper _mapper;

        public DespesaAppService(ILogger<ClienteAppService> logger,
                                 IDespesaService despesaService,
                                 IMapper mapper) 
        {
            _logger = logger;
            _despesaService = despesaService;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(DespesaViewModel despesaViewModel)
        {
            try
            {
                return await _despesaService.AddAsync(_mapper.Map<Despesa>(despesaViewModel));
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw new Exception($"Erro ao tentar adicionar uma despesa: {ex.Message}", ex);
            }
        }

        public void Dispose()
        {
            _despesaService.Dispose();
        }
    }
} 