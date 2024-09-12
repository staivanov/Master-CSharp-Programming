using Section20.CleanCode.SOLID.I;

namespace CleanCode
{
    public class Program
    {
        public static void Main()
        {   //S
            //Invoice invoice = new() { Amount = 100 };
            //BillingService billingService = new();
            //double total = billingService.CalculateTotal(invoice);
            //WriteLine($"Total {total}");

            //DiscountInvoice discountInvoice = new() { Amount = 100, Discount = 25 };
            //DiscountBillingService discountBillingService = new();

            //WriteLine(discountBillingService.CalculateTotal(discountInvoice));

            //I
            IWorkable human = new Worker();
            human.Work();
            ((IEatable)human).Eat();

            //D



        }
    }
}
