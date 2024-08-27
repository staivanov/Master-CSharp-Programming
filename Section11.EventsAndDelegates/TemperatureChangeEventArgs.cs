namespace Section11.EventsAndDelegates
{
    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangeEventArgs: EventArgs
    {
        public int Temperature { get;}

        public TemperatureChangeEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
