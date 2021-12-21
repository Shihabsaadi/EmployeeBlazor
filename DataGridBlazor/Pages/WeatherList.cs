using EmployeeWebClient.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherModel;

namespace DataGridBlazor.Pages
{
    public class WeatherList : ComponentBase
    {
        [Inject]
        public IWeatherService WeatherService { get; set; }

        public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }
        public WeatherForecast WeatherForecast { get; set; }


        protected override async Task OnInitializedAsync()
        {
            WeatherForecast = (await WeatherService.GetWeather());
        }
    }
}
