using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Vinder.Comanda.Orders.TestSuite.Fixtures;

public sealed class BypassAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder) :
    AuthenticationHandler<AuthenticationSchemeOptions>(options, logger, encoder)
{
    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, "vinder"),
            new Claim(ClaimTypes.NameIdentifier, "vinder"),

            new Claim(ClaimTypes.Role, Permissions.ViewOrders),
            new Claim(ClaimTypes.Role, Permissions.CreateOrder),
            new Claim(ClaimTypes.Role, Permissions.UpdateOrder),
        };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);

        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return Task.FromResult(AuthenticateResult.Success(ticket));
    }
}