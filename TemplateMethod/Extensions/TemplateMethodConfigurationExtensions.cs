using Microsoft.Extensions.DependencyInjection;
using TemplateMethod.Template;

namespace TemplateMethod.Extensions;

public static class TemplateMethodConfigurationExtensions
{
    public static void ConfigureTemplateMethod(this IServiceCollection services)
    {
        services.AddScoped<IDataImporter, SqlDataImporter>();
    }
}