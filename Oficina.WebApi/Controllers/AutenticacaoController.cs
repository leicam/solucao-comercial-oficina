using Microsoft.AspNetCore.Mvc;
using Oficina.Dominio.nsInterfaces.nsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.WebApi.Controllers
{
    [Route("api/autenticacao")]
    public class AutenticacaoController
    {
        private readonly IUsuarioServico _usuarioServico;

        public AutenticacaoController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

    }
}