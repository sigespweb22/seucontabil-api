using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;
using BoxBack.Infra.Data.Context;

namespace BoxBack.Infra.Data.Repository
{
    public class DespesaRepository : Repository<Despesa>, IDespesaRepository
    {
        private readonly BoxAppDbContext _context;

        public DespesaRepository(BoxAppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}