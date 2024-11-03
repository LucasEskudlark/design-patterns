using Builder.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Builder.Extensions;

public static class BuilderPatternConfigurationExtensions
{
    public static void ConfigureBuilderPattern(this IServiceCollection services)
    {
        services.AddScoped<IOrderBuilder, OrderBuilder>();
    }
}