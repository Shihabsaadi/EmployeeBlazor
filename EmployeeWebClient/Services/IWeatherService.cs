using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherModel;

namespace EmployeeWebClient.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecast> GetWeather();
        Task<IEnumerable<WeatherForecast>> GetWeathers();
    }
}
