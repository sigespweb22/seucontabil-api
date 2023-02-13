using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BoxBack.Application.Interfaces;
using BoxBack.Application.ViewModels;
using BoxBack.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoxBack.Application.AppServices
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ILogger _logger;
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteAppService(ILogger<ClienteAppService> logger,
                                 IClienteService clienteService,
                                 IMapper mapper)
        {
            _logger = logger;
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteService.GetAllAsync());
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }
    }
} 