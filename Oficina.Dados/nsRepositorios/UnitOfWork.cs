using Oficina.Dominio.nsInterfaces.nsRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dados.nsRepositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUsuarioAdministradorRepositorio _usuarioAdministradorRepositorio;

        public IUsuarioAdministradorRepositorio UsuarioRepositorio => _usuarioAdministradorRepositorio;

        public UnitOfWork(IUsuarioAdministradorRepositorio usuarioAdministradorRepositorio)
        {
            _usuarioAdministradorRepositorio = usuarioAdministradorRepositorio;
        }
    }
}