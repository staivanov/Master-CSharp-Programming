using Section9.Interfaces.Interfaces;

namespace Section9.Interfaces
{
    public class PaypalProcessor : IPaymentProcesser
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount}");
        }
    }
}
