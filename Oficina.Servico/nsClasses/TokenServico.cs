using Microsoft.IdentityModel.Tokens;
using Oficina.Dominio.nsInterfaces.nsServices;
using Oficina.DTO.nsClasses;
using Oficina.Utilidades.nsClasses;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Oficina.Servico.nsClasses
{
    public class TokenServico : ITokenServico
    {
        private readonly JwtSecurityTokenHandler _handler = new JwtSecurityTokenHandler();

        public string Gerar(TokenDTO dto)
            => _handler.WriteToken(_handler.CreateToken(GetTokenDescriptor(dto.Email)));

        private SecurityTokenDescriptor GetTokenDescriptor(string email)
            => new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, email),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(GetChave()), SecurityAlgorithms.HmacSha256Signature),
            };

        private byte[] GetChave() => Encoding.ASCII.GetBytes(Configuracoes.Chave);
    }
}