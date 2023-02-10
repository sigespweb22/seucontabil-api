using BoxBack.Infra.Data.Repository;
using BoxBack.Domain.Models;
using BoxBack.Infra.Data.Context;
using Sigesp.Domain.Interfaces;

namespace Sigesp.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>
    {
        public ClienteRepository(BoxAppDbContext context)
            : base(context)
        {
        }
    }
}