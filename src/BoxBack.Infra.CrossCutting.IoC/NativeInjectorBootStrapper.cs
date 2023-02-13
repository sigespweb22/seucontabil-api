using Microsoft.Extensions.DependencyInjection;
using BoxBack.Infra.Data.UoW;
using BoxBack.Domain.InterfacesNoSQL;
using BoxBack.Infra.Data.RepositoryNoSQL;
using BoxBack.Application.Interfaces;
using BoxBack.Infra.CrossCutting.Identity.Services;
using BoxBack.Application.AppServices;
using BoxBack.Infra.Data.Repository;
using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Interfaces;
using BoxBack.Domain.Services;

namespace BoxBack.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Transient: Created each time.
            // Scoped: Created only once per request.
            // Singleton: Created the first time they are requested. Each subsequent request uses the instance that was created the first time.

            // Application - AppServices
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IDespesaAppService, DespesaAppService>();
            services.AddScoped<INavigationAppService, NavigationAppService>();

            // Domain - Services
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IDespesaService, DespesaService>();

            // Infra Data - Repositories
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IDespesaRepository, DespesaRepository>();

            // Repo NoSQL
            services.AddTransient<IClienteRepositoryNoSQL, ClienteRepositoryNoSQL>();

            // Services miscellaneous
            services.AddScoped<UserResolverService>();
            services.AddScoped<ValidationResult>();            
        }
    }
}