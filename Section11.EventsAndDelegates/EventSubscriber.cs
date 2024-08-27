using static System.Console;

namespace Section11.EventsAndDelegates
{
    public class EventSubscriber
    {
        public void OnEventRaised(string message)
            => WriteLine($"Event received: {message}");
    }
}
