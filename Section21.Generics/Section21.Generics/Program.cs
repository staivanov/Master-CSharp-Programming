namespace Section21.Generics
{
    public class Program
    {
        public static void Main()
        {
            Repository<Product> repository = new Repository<Product>();
            Product product = new();
            repository.Add(product);

            Action action = () => { Console.WriteLine("Hello World"); };
            action();

            Func<string> getName = () =>
            {
                return "Jax";
            };

            string? myName = getName();
        }
    }
}
