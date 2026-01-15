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
        services.AddIdentityServer();
        services.AddFluentValidationAutoValidation(options =>
        {
            options.DisableDataAnnotationsValidation = true;
        });

        services.AddOpenApi(options =>
        {
            options.AddScalarTransformers();
            options.AddDocumentTransformer((document, _, _) =>
            {
                document.Components ??= new Microsoft.OpenApi.Models.OpenApiComponents();
                document.Components.SecuritySchemes[SecuritySchemes.OAuth2] =
                    new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                    {
                        Type = Microsoft.OpenApi.Models.SecuritySchemeType.OAuth2,
                        Flows = new Microsoft.OpenApi.Models.OpenApiOAuthFlows
                        {
                            ClientCredentials = new Microsoft.OpenApi.Models.OpenApiOAuthFlow
                            {
                                TokenUrl = new Uri(settings.Federation.BaseUrl + "/api/v1/openid/connect/token")
                            }
                        }
                    };

                return Task.CompletedTask;
            });
        });
    }
}