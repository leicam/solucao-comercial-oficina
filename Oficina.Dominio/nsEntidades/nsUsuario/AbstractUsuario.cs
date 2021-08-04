using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.nsEntidades.nsUsuario
{
    public abstract class AbstractUsuario : AbstractEntidade
    {
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}