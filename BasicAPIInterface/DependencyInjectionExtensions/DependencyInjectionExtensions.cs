using BasicAPIInterface.Domain.Managers.Repositories;
using BasicAPIInterface.Domain.Managers.Validators;
using BasicAPIInterface.Domain.Services;

namespace BasicAPIInterface.DependencyInjectionExtensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            services.AddScoped<IBookService, BookService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastRepo, WeatherForecastSimpleRepo>();
            services.AddSingleton<IBooksRepo, BooksRepo>();

            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IBookValidation, BookValidation>();

            return services;
        }

    }
}
