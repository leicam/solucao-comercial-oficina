namespace Oficina.DTO.nsClasses
{
    public class TokenDTO
    {
        public string Email { get; private set; }

        public TokenDTO(string email)
        {
            Email = email;
        }
    }
}