
namespace Section10.Struct
{
    internal class Program
    {
        static void Main()
        {
            DateTime dateTime = new(2018, 5, 31);

            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);


        }


        public static DateTime GetTomorrow()
            => DateTime.Today.AddDays(1);
    }
}
