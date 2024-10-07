using BasicAPIInterface.Domain.Managers.Repositories;
using BasicAPIInterface.Domain.Services;

namespace BasicAPIInterface.DependencyInjectionExtensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastRepo, WeatherForecastSimpleRepo>();


            return services;
        }
    }
}
