using Microsoft.AspNetCore.Components;
using ServiceStack;
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
        [Inject]
        IHttpClientFactory ClientFactory { get; set; }
        public async Task<WeatherForecast> GetWeather()
        {
            //return await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44319/WeatherForecast/1");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");
            var client = ClientFactory.CreateClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var weatherForecast = await JsonSerializer.DeserializeAsync
                    <WeatherForecast>(responseStream);
                return weatherForecast;
            }
            else
                throw new NotImplementedException();
        }

        Task<IEnumerable<WeatherForecast>> IWeatherService.GetWeathers()
        {
            throw new NotImplementedException();
        }
    }
}
