namespace Section20.CleanCode.SOLID.O
{
    public class DiscountBillingService : BillingService
    {
        public override double CalculateTotal(Invoice invoice)
        {
            if (invoice is DiscountInvoice discountInvoice)
            {
                double discountResult = discountInvoice.Amount - discountInvoice.Discount;
                return discountResult;
            }

            return base.CalculateTotal(invoice);
        }
    }
}
