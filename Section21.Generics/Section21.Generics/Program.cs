using static System.Console;

namespace Section21.Generics
{
    public class Program
    {
        public static void Main()
        {
            Box<string> boxStr = new Box<string>("Hello World");
            boxStr.UpdateContent("Teaching C# is fun");
            WriteLine(boxStr.GetContent());





            
        }
    }
}
