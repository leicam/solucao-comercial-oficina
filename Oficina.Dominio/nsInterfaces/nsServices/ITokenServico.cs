using Oficina.DTO.nsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.nsInterfaces.nsServices
{
    public interface ITokenServico
    {
        string Gerar(UsuarioDTO usuario);
    }
}