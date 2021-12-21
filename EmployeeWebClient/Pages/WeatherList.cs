using EmployeeWebClient.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherModel;

namespace EmployeeWebClient.Pages
{
    public class WeatherList : ComponentBase
    {
        [Inject]
        public IWeatherService WeatherService { get; set; }

        public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            WeatherForecasts = (await WeatherService.GetWeathers()).ToList();
        }
    }
}
