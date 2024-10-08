﻿using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Services
{
    public interface IWeatherForecastService
    {
        Task<List<WeatherForecast>> GetAll();
    }
}
