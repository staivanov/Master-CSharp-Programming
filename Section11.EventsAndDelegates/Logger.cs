using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Section11.EventsAndDelegates
{
    public delegate void LogHandler(string message);

    internal class Logger
    {


        public  void LogToConsole(string message)
            => WriteLine($"Console log: {message}");
    }
}
