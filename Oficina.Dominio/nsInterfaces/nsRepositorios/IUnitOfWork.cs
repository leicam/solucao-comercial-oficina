using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.nsInterfaces.nsRepositorios
{
    public interface IUnitOfWork
    {
        public IUsuarioAdministradorRepositorio UsuarioRepositorio { get; }
    }
}