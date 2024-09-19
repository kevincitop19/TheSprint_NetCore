using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructura.Commons.Config.Context;
using POS.Infrastructura.Interface;
using POS.Infrastructura.Mapper;
using POS.Infrastructura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Extension
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructura(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(PruebabackendContext).Assembly.FullName;

            services.AddDbContext<PruebabackendContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("POSConnection"),
                    b => b.MigrationsAssembly(assembly)
                 )
            );
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPersonaRepository, PersonaRepository>();

            //automapper
            services.AddAutoMapper(typeof(MappingUsuario).Assembly);
            return services;
        }
    }
}
