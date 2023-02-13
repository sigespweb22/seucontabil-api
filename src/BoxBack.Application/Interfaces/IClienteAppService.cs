using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoxBack.Application.ViewModels;

namespace BoxBack.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        Task<IEnumerable<ClienteViewModel>> GetAllAsync();
    }
}