using BasicAPIInterface.Domain.Managers.Repositories;
using BasicAPIInterface.Domain.Models;
using BasicAPIInterface.Domain.Services;
using Moq;

namespace TestProject1
{
    public class WeatherForecastUnitTests
    {
        private readonly Mock<IWeatherForecastRepo> _weatherForecastRepoMock;

        public WeatherForecastUnitTests()
        {
            _weatherForecastRepoMock = new Mock<IWeatherForecastRepo>();
            var expectedRepo = new List<WeatherForecast>
            {
                new WeatherForecast()
                {
                    Date = new DateOnly(2020, 01, 01),
                    TemperatureC = 20,
                    Summary = "Windy"
                },
                new WeatherForecast
                {
                    Date = new DateOnly(2020, 01, 02),
                    TemperatureC = 25,
                    Summary = "Sunny"
                }
            };
            _weatherForecastRepoMock.Setup(x => x.GetAll())
                .Returns(Task.FromResult(expectedRepo));
        }
        
        [Fact]
        public async Task TestService()
        {
            var weatherForecastService = new WeatherForecastService(_weatherForecastRepoMock.Object);
            Assert.NotNull(await _weatherForecastRepoMock.Object.GetAll());
            Assert.NotNull(await weatherForecastService.GetAll());
            Assert.Equal(2,(await weatherForecastService.GetAll()).Count);
            Assert.Equal("Unknown", (await weatherForecastService.GetAll())[0].Summary);
        }
    }
}