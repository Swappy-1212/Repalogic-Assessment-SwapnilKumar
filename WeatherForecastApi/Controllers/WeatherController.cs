using Microsoft.AspNetCore.Mvc;
using WeatherForecastApi.Services;

namespace WeatherForecastApi.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index(string city = "London")
        {
            ViewBag.City = city;

            var forecast = _weatherService.GetForecastByCity(city);
            return View(forecast);
        }
    }
}
