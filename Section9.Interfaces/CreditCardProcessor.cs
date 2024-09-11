using Section9.Interfaces.Interfaces;
using static System.Console;

namespace Section9.Interfaces
{
    internal class CreditCardProcessor : IPaymentProcesser
    {
        public void ProcessPayment(decimal amount)
        {
            WriteLine($"Processing credit card paiment.");
        }
    }
}
