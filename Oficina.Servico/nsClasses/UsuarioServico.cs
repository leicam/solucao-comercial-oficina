using Oficina.Dominio.nsInterfaces.nsRepositorios;
using Oficina.Dominio.nsInterfaces.nsServices;
using Oficina.DTO.nsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Servico.nsClasses
{
    public class UsuarioServico : AbstractServico,IUsuarioServico
    {
        public UsuarioServico(IUnitOfWork iuow) : base(iuow) { }

        public string Autenticar(UsuarioDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
