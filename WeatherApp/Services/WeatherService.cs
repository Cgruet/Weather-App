using WeatherApp.Services.Interfaces;

namespace WeatherApp.Services
{
    public class WeatherService  : IWeatherService
    {
        public String getCurrentWeatherForcast(String day)
        {
            if (day == "Monday")
            {
                return "Is cloudy";
            }

            return "Perfect Weather";
        }
    }
}
