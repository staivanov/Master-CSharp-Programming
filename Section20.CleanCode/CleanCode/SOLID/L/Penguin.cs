namespace Section20.CleanCode.SOLID.L
{
    public class Penguin : Bird
    {
        public override void Fly()
            => throw new NotImplementedException("Penguin can't fly.");
    }
}
