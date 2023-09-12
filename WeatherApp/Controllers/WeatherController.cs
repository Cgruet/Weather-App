using Microsoft.AspNetCore.Mvc;
using WeatherApp.Services.Interfaces;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        public IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService) { 
            _weatherService = weatherService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetWeatherForcast(String day)
        {
            var result = _weatherService.getCurrentWeatherForcast(day);

            return View();
        }
    }
}
