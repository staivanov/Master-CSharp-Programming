using static System.Console;

namespace LiNQ
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddPrinter(numbers);
        }


        private static void OddPrinter(int[] numbers)
        {
            WriteLine("Odd numbers:");

            IEnumerable<int> oddNumbers = from number in numbers
                                          where number % 2 != 0
                                          select number;

            foreach (int number in oddNumbers)
            {
                Write(number + " ");
            }
        }
    }
}
