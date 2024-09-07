namespace Section21.Generics
{
    public class Comparer
    {
        public static bool AreEqual<T>(T first, T second) where T : class
            => first == second;
    }
}
