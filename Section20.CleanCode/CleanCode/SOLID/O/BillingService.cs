namespace Section20.CleanCode.SOLID.O
{
    public class BillingService
    {
        public virtual double CalculateTotal(Invoice invoice)
                => invoice.Amount;
    }
}
