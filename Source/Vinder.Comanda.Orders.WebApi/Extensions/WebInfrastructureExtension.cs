namespace Vinder.Comanda.Orders.WebApi.Extensions;

[ExcludeFromCodeCoverage(Justification = "contains only web infrastructure configuration with no business logic.")]
public static class WebInfrastructureExtension
{
    public static void AddWebComposition(this IServiceCollection services, IWebHostEnvironment environment)
    {
        var settings = services
            .BuildServiceProvider()
            .GetRequiredService<ISettings>();

        services.AddControllers();
        services.AddHttpContextAccessor();
        services.AddEndpointsApiExplorer();
        services.AddCorsConfiguration();
        services.AddOpenApi();
        services.AddIdentityServer();
        services.AddFluentValidationAutoValidation(options =>
        {
            options.DisableDataAnnotationsValidation = true;
        });
    }
}