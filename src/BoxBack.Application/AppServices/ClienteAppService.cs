using BoxBack.Application.Interfaces;
using BoxBack.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoxBack.Application.AppServices
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ILogger _logger;
        private readonly IClienteService _clienteService;

        public ClienteAppService(ILogger<ClienteAppService> logger,
                                 IClienteService clienteService) 
        {
            _logger = logger;
            _clienteService = clienteService;
        }
    }
} 