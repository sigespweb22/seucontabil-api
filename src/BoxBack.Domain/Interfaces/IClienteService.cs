using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoxBack.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BoxBack.Domain.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAll();
    }
}