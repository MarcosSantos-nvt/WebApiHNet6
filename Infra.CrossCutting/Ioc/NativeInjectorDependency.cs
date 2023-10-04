using Application.Services;
using Application.ServicesInterfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UnitOfWork;
using Infra.Data.Repositories;
using Infra.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.Ioc
{
    public static class NativeInjectorDependency
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //REPOSITORIES
            services.AddScoped<ICursoRepository, CursoRepository>();

            //SERVICES
            services.AddScoped<ICursoAppService, CursoAppSercice>();

            //CROSSCUTTING
            services.AddScoped<IUnitOfWorkPersistence, UnitOfWorkPersistence>();
        }
    }
}
