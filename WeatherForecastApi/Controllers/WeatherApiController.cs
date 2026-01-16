using Microsoft.AspNetCore.Mvc;
using WeatherForecastApi.Services;

namespace WeatherForecastApi.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherApiController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherApiController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public IActionResult Get(string city)
        {
            var data = _weatherService.GetForecastByCity(city);
            return Ok(data);
        }
    }
}
