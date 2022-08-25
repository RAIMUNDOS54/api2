using api2.Configurations;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace api2.Repositories
{
    public class UserRepository
    {
        public async Task<string?> LoginAsync(User user)
        {
            if (user.UserName == "user" && user.Password == "user")
            {
                return await GenerateJWT();
            }
            else
            {
                throw new($"ERRO 00: Dados incorretos para autenticação com os dados informados. Usuário: {user.UserName}, Senha: {user.Password}");
            }
        }
        private async Task<string> GenerateJWT()
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTConfiguration.SigningKey));
            var credentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
            issuer: JWTConfiguration.ValidIssuer,
            audience: JWTConfiguration.ValidAudience,
            claims: null,
            expires: System.DateTime.Now.AddMinutes(120),
            signingCredentials: credentials);

            return await Task.Run(() => new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}
