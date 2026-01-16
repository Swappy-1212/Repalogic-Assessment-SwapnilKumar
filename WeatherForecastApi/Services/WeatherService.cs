using WeatherForecastApi.Services;
using WeatherForecastApi;
using WeatherForecastApi.Models;

public class WeatherService : IWeatherService
{
    private readonly List<WeatherForecast> _weatherData;

    //public WeatherService()
    //{
    //    _weatherData = new List<WeatherForecast>
    //    {
    //        new WeatherForecast
    //        {
    //            City = "London",
    //            Date = DateTime.Today,
    //            Temperature = 15,
    //            Summary = "Cloudy"
    //        },
    //        new WeatherForecast
    //        {
    //            City = "London",
    //            Date = DateTime.Today.AddDays(1),
    //            Temperature = 17,
    //            Summary = "Sunny"
    //        },
    //        new WeatherForecast
    //        {
    //            City = "Paris",
    //            Date = DateTime.Today,
    //            Temperature = 18,
    //            Summary = "Sunny"
    //        },
    //        new WeatherForecast
    //        {
    //            City = "Paris",
    //            Date = DateTime.Today.AddDays(1),
    //            Temperature = 16,
    //            Summary = "Rainy"
    //        }
    //    };
    //}
    public WeatherService()
    {
            _weatherData = new List<WeatherForecast>
        {
            // London
            new WeatherForecast { City = "London", Date = DateTime.Today, Temperature = 15, Summary = "Cloudy" },
            new WeatherForecast { City = "London", Date = DateTime.Today.AddDays(1), Temperature = 17, Summary = "Sunny" },

            // Paris
            new WeatherForecast { City = "Paris", Date = DateTime.Today, Temperature = 18, Summary = "Sunny" },
            new WeatherForecast { City = "Paris", Date = DateTime.Today.AddDays(1), Temperature = 16, Summary = "Rainy" },

            // New York
            new WeatherForecast { City = "New York", Date = DateTime.Today, Temperature = 20, Summary = "Clear" },
            new WeatherForecast { City = "New York", Date = DateTime.Today.AddDays(1), Temperature = 22, Summary = "Sunny" },

            // Tokyo
            new WeatherForecast { City = "Tokyo", Date = DateTime.Today, Temperature = 25, Summary = "Humid" },
            new WeatherForecast { City = "Tokyo", Date = DateTime.Today.AddDays(1), Temperature = 26, Summary = "Rainy" },

            // Sydney
            new WeatherForecast { City = "Sydney", Date = DateTime.Today, Temperature = 23, Summary = "Windy" },
            new WeatherForecast { City = "Sydney", Date = DateTime.Today.AddDays(1), Temperature = 24, Summary = "Sunny" },

            // Berlin
            new WeatherForecast { City = "Berlin", Date = DateTime.Today, Temperature = 14, Summary = "Overcast" },
            new WeatherForecast { City = "Berlin", Date = DateTime.Today.AddDays(1), Temperature = 16, Summary = "Clear" },

            // Toronto
            new WeatherForecast { City = "Toronto", Date = DateTime.Today, Temperature = 12, Summary = "Cold" },
            new WeatherForecast { City = "Toronto", Date = DateTime.Today.AddDays(1), Temperature = 14, Summary = "Partly Cloudy" },

            // Dubai
            new WeatherForecast { City = "Dubai", Date = DateTime.Today, Temperature = 34, Summary = "Hot" },
            new WeatherForecast { City = "Dubai", Date = DateTime.Today.AddDays(1), Temperature = 36, Summary = "Very Hot" }
        };
    }

    public IEnumerable<WeatherForecast> GetForecastByCity(string city)
    {
        return _weatherData.Where(w =>
            w.City.Equals(city, StringComparison.OrdinalIgnoreCase));
    }
}
