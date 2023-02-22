
using System;
using System.Threading.Tasks;
using BoxBack.Application.ViewModels;

namespace BoxBack.Application.Interfaces
{
    public interface IDespesaParcelaAppService : IDisposable
    {
        Task<bool> AddAsync(DespesaViewModel despesaViewModel);
    }
}