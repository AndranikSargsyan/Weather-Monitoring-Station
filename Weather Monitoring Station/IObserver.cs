namespace Weather_Monitoring_Station
{
    interface IObserver
    {
        void update(double temperature, double humidity, double pressure);
    }
}
