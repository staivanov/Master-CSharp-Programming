namespace Section22.Threads
{
    public class Program
    {
        public static void Main()
        {
            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                new Thread(() =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started.");
                    Thread.Sleep(1000);

                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended.");
                }).Start();
            });
        }
    }
}
