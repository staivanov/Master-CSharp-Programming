using Section9.Interfaces.Interfaces;

namespace Section9.Interfaces
{
    internal class Program
    {
        static void Main()
        {
            IPaymentProcesser creditCardProcesser = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcesser);
            paymentService.ProcessOrderPayment(100.0m);
            IPaymentProcesser paypalProcessor = new PaypalProcessor();
            paymentService.ProcessOrderPayment(200.0m);



        }
    }
}
