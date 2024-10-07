using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Managers.Repositories
{
    public class WeatherForecastSimpleRepo : IWeatherForecastRepo
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        public async Task<List<WeatherForecast>> GetAll()
        {
            return await Task.Run(() =>
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                    })
                    .ToList();
            });
        }
    }
}
