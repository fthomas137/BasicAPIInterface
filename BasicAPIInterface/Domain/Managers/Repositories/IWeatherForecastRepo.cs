using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Managers.Repositories
{
    public interface IWeatherForecastRepo
    {
        Task<List<WeatherForecast>> GetAll();
    }
}
