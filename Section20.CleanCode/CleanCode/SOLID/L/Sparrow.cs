namespace Section20.CleanCode.SOLID.L
{
    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
            => Console.WriteLine("Sparrow is flying.");
    }
}
