using BasicAPIInterface.Domain.Managers.Repositories;
using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepo _weatherForecastRepo;

        public WeatherForecastService(IWeatherForecastRepo weatherForecastRepo)
        {
            _weatherForecastRepo = weatherForecastRepo;
        }

        public async Task<List<WeatherForecast>> GetAll()
        {
            var result = await _weatherForecastRepo.GetAll();
            result[0].Summary = "Unknown";
            return result;
        }
    }
}
