using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;
using BoxBack.Infra.Data.Context;

namespace BoxBack.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly BoxAppDbContext _context;

        public ClienteRepository(BoxAppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}