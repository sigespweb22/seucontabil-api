
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoxBack.Domain.Models;

namespace BoxBack.Domain.Interfaces
{
    public interface IDespesaParcelaService : IDisposable
    {
        Task<bool> AddRangeWhithoutCommitAsync(IEnumerable<DespesaParcela> despesaParcelas);
    }
}