namespace Section11.EventsAndDelegates
{
    //Subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangeEventArgs e)
            => Console.WriteLine($"Alert: temperature is {e.Temperature} sender is {sender}");
    }
}
