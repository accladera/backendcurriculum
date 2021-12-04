using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Services.Repository.CurriculumRepository;
using System.Reflection;

namespace Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Todos los repositorys
            services.AddTransient<ICurriculumRepository, CurriculumRepository>();

            return services;
        }

    }
}
