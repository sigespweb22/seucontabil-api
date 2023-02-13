
using System;
using System.Threading.Tasks;
using BoxBack.Domain.Models;

namespace BoxBack.Domain.Interfaces
{
    public interface IDespesaService : IDisposable
    {
        Task<bool> AddAsync(Despesa despesa);
    }
}