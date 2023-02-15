
using System;
using System.Threading.Tasks;
using BoxBack.Domain.Models;

namespace BoxBack.Domain.Interfaces
{
    public interface IDespesaParcelaService : IDisposable
    {
        Task<bool> AddAsync(DespesaParcela despesaParcela);
    }
}