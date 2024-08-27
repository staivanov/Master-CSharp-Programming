using Section9.Interfaces.Interfaces;

namespace Section9.Interfaces
{
    internal class CreditCardProcessor : IPaymentProcesser
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card paiment.");
        }
    }
}
