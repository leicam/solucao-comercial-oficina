namespace Oficina.Dominio.nsEntidades.nsUsuario
{
    public abstract class AbstractUsuario : AbstractEntidade
    {
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}