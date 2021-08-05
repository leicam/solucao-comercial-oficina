using Oficina.DTO.nsClasses;

namespace Oficina.Dominio.nsInterfaces.nsServices
{
    public interface IUsuarioServico
    {
        string Autenticar(UsuarioDTO dto);
    }
}