using Section17.LiNQ;
using static System.Console;

namespace LiNQ
{
    public class Program
    {
        public static void Main()
        {
            UniversityManager uniManager = new();
            //uniManager.MaleStudents();
            //uniManager.FemaleStudents();
            uniManager.SortStudentByAge();
            uniManager.AllStudentsFromBeijingTech();
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
