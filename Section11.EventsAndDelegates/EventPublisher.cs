using static Section11.EventsAndDelegates.Program;

namespace Section11.EventsAndDelegates
{
    internal class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
            => OnNotify?.Invoke(message); //Invoke the event if there are any subscribers.

    }
}
