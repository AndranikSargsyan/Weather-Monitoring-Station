/*
 * Author: Andranik Sargsyan 
*/

namespace Weather_Monitoring_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            
			CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);
            
			WeatherStation weatherStation = new WeatherStation(weatherData);
            
			weatherStation.start();
        }
    }
}
