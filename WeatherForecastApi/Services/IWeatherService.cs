using WeatherForecastApi.Models;

namespace WeatherForecastApi.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetForecastByCity(string city);
    }
}
