namespace Weather_Monitoring_Station
{
    class CurrentConditionsDisplay : IObserver
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }

        public void display()
        {
            System.Console.WriteLine("Current conditions:");
            System.Console.WriteLine("-Temperature: " + temperature.ToString("F") + " C");
            System.Console.WriteLine("-Humidity: " + humidity.ToString("F") + "%");
            System.Console.WriteLine("-Pressure: " + pressure.ToString("F") + " mmHg");
            System.Console.WriteLine();
        }
    }
}
