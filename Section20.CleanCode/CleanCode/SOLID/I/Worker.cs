namespace Section20.CleanCode.SOLID.I
{
    public class Worker : IWorkable, IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}
