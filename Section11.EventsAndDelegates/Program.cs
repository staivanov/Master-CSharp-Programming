using static System.Console;

namespace Section11.EventsAndDelegates
{
    public delegate void TemperatureChangeHandler(string message);

    internal class Program
    {
        //Declaration
        public delegate void Notify(string message);

        static void Main()
        {
            ////Instantation
            //Notify notifyDelegate = ShowMessage;

            ////Invocation
            //notifyDelegate("Hello delegates");

            Logger logger = new();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Opaaa");

            Person[] people =
            {
                new() {Name = "Alex", Age = 30},
                new() {Name = "Jax", Age = 25},
                new() {Name = "Lisa", Age = 45},
                new() {Name = "Julia", Age = 54}
            };

            PersonSorter personSorter = new();
            personSorter.Sort(people, CompareByAge);

            //Sort people by age.
            foreach (Person person in people)
            {
                WriteLine($"{person.Name} {person.Age}");
            }

            EventPublisher publisher = new();
            EventSubscriber subscriber = new();
            publisher.OnNotify += subscriber.OnEventRaised;


            TemperatureMonitor monitor = new();
            TemperatureAlert alert = new();

            monitor.TemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            monitor.Temperature = int.Parse(ReadLine());


        }

        private static int CompareByAge(Person x, Person y)
            => x.Age.CompareTo(y.Age);

        private static int CompareByName(Person x, Person y)
            => x.Name.CompareTo(y.Name);

        public static void ShowMessage(string message)
            => WriteLine(message);
    }
}
