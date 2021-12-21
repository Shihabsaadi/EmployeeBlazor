using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherModel;
namespace EmployeeWebClient.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient httpClient;

        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<WeatherForecast> GetWeather()
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast>("WeatherForecast/1");
        }

        async Task<IEnumerable<WeatherForecast>> IWeatherService.GetWeathers()
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
