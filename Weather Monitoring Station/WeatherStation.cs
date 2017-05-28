namespace Weather_Monitoring_Station
{
    class WeatherStation
    {
        private WeatherData weatherData;

        public WeatherStation(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void start()
        {      
            while (true)
            {
                System.Random rand = new System.Random();
                // This will generate double number between 20 and 30
                double temperature = rand.NextDouble() * (30 - 20) + 20;
                // This will generate double number between 60 and 80
                double humidity = rand.NextDouble() * (60 - 80) + 60;
                // This will generate double number between 680 and 700
                double pressure = rand.NextDouble() * (700 - 680) + 680;
                weatherData.setMeasurements(temperature, humidity, pressure);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
