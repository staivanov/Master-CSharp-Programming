namespace Section11.EventsAndDelegates
{
    public delegate int Comparison<T>(T x, T y);

    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }



    }
}
