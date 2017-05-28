namespace Weather_Monitoring_Station
{
    interface ISubject
    {
         void registerObserver(IObserver o);
         void removeObserver(IObserver o);
         void notifyObservers();
    }
}
