using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;
using BoxBack.Infra.Data.Context;

namespace BoxBack.Infra.Data.Repository
{
    public class DespesaParcelaRepository : Repository<DespesaParcela>, IDespesaParcelaRepository
    {
        private readonly BoxAppDbContext _context;

        public DespesaParcelaRepository(BoxAppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}