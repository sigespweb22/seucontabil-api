using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;

namespace BoxBack.Domain.InterfacesRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        ValidationResult CommitVR();
        Task<ValidationResult> CommitAsyncVR();
        Task<bool> CommitAsync();
        void CommitWithoutSoftDelete();
    }
}
