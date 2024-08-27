using Section9.Interfaces.Interfaces;

namespace Section9.Interfaces
{
    public class PaymentService
    {
        private readonly IPaymentProcesser _processor;

        public PaymentService(IPaymentProcesser processor)
            => _processor = processor;

        public void ProcessOrderPayment(decimal amount)
            => _processor.ProcessPayment(amount);
    }
}
