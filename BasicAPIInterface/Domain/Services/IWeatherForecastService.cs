using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Services
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> GetAll();
    }
}
