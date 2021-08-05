using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oficina.Dados.nsContext;
using Oficina.Dados.nsRepositorios;
using Oficina.Dominio.nsInterfaces.nsRepositorios;
using Oficina.Dominio.nsInterfaces.nsServices;
using Oficina.Servico.nsClasses;
using Oficina.Utilidades.nsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.IoC.nsExtensions
{
    public static class IoCExtensions
    {
        public static void InjetarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexto

            services.AddDbContext<OficinaContexto>(x
                => x.UseMySql(configuration.GetDefaultConnectionString(), ServerVersion.AutoDetect(configuration.GetDefaultConnectionString())));
            services.AddScoped<OficinaContexto>();

            #endregion Contexto

            #region Servicos

            services.AddScoped<ITokenServico, TokenServico>();
            services.AddScoped<IUsuarioServico, UsuarioServico>();

            #endregion Servicos

            #region Repositorios

            services.AddScoped<IUsuarioAdministradorRepositorio, UsuarioAdministradorRepositorio>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion Repositorios
        }

    }
}