using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoxBack.Domain.Models;

namespace BoxBack.Domain.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
    }
}