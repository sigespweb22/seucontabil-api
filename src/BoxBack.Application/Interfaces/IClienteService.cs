using System.Collections.Generic;
using System.Threading.Tasks;
using BoxBack.Application.ViewModels;

namespace BoxBack.Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteViewModel>> GetAll();
    }
}