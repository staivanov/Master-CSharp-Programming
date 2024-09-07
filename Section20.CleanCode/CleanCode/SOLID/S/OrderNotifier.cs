using static System.Console;

namespace Section20.CleanCode.SOLID.S
{
    public class OrderNotifier
    {
        public void NotifyCustomer(Order order)
           => WriteLine($"Customer notified for order {order.Id}.");
    }
}
