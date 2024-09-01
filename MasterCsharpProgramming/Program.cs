using Section8._Inheritance.EmployeeDemo;

namespace MasterCsharpProgramming
{
    public class Program
    {
        public static void Main()
        {
            //Dog myDog = new();
            //myDog.Eat();
            //myDog.Bark();
            //Console.WriteLine("Make sound from Animal and Dog: ");
            //myDog.MakeSound();

            Employee jax = new("Joe", 35, "Doctor", 12345);
            jax.DisplayPersonInfo();
            jax.DisplayEmployeeInfo();



        }
    }
}
