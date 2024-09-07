using static System.Console;

namespace Section20.CleanCode.SOLID.S
{
    public class OrderLogger
    {
        public void LogOrder(Order order)
            => WriteLine($"Order {order.Id} logged.");
    }
}
