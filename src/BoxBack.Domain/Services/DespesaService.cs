using AutoMapper;
using Microsoft.Extensions.Logging;
using BoxBack.Domain.Interfaces;
using System.Threading.Tasks;
using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;

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

        public Task<bool> AddAsync(Despesa despesa)
        {
            #region Entity validations
            
            #endregion

            #region Persistance
            #endregion

            #region Commit
            #endregion

            return Task.Run(() => true);
        }
    
        public void Dispose()
        {
            _despesaRepository.Dispose();
        }
    }
}