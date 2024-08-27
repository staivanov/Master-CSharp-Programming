namespace Section11.EventsAndDelegates
{
    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;

        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature
        {
            get => _temperature;

            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangeEventArgs(_temperature));
                }
            }

        }

        protected virtual void OnTemperatureChanged(TemperatureChangeEventArgs e) // Leting every subscriber know!
            => TemperatureChanged?.Invoke(this, e);
    }
}
