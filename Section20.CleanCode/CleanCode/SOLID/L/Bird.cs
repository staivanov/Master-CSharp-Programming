namespace Section20.CleanCode.SOLID.L
{
    public class Bird : IFlyable
    {
        public void Fly()
            => throw new NotImplementedException("Penguin can't fly.");
        public virtual void Sound()
            => Console.WriteLine("Sound from bird.");
    }
}
