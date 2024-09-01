using static System.Console;

namespace Section11.EventsAndDelegates
{
    public delegate void LogHandler(string message);

    internal class Logger
    {


        public void LogToConsole(string message)
            => WriteLine($"Console log: {message}");
    }
}
