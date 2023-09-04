using MercadoMagico.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace MercadoMagico.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly DataContext _dbContext;


        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            DataContext dbContext)
            : base(options, logger, encoder, clock)
        {
            _dbContext = dbContext;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Você não tem autorização");


            try
            {
                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string emailAddress = credentials[0];
                string password = credentials[1];

                var user = await _dbContext.Usuarios.FirstOrDefaultAsync(user => user.Email == emailAddress && user.Senha == password);

                if (user == null)
                {
                    return AuthenticateResult.Fail("Email ou senha inválidos. Tente novamente.");

                } else
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, user.Email) };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }

            } catch (Exception)
            {
                return AuthenticateResult.Fail("Aconteceu algum erro.");
            }

        }
    }
}
 