using System.Threading.Tasks;
using BoxBack.Application.Interfaces;
using BoxBack.Application.ViewModels;
using BoxBack.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoxBack.Application.AppServices
{
    public class DespesaAppService
    {
        private readonly ILogger _logger;
        private readonly IDespesaService _despesaService;

        public DespesaAppService(ILogger<ClienteAppService> logger,
                                 IDespesaService despesaService) 
        {
            _logger = logger;
            _despesaService = despesaService;
        }

        public async Task<bool> AddAsync(DespesaViewModel despesaViewModel)
        {
            try
            {
                return await _despesaService.AddAsync(despesaViewModel);
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw;
            }
        }
    }
} 