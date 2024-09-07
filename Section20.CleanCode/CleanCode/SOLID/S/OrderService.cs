namespace Section20.CleanCode.SOLID.S
{
    public class OrderService
    {
        private List<Order> _orders = new List<Order>();
        private OrderLogger _orderLogger = new OrderLogger();
        private OrderNotifier _orderNotifier = new OrderNotifier();

        public void AddOrders(Order order)
        {
            _orders.Add(order);
            _orderLogger.LogOrder(order);
            _orderNotifier.NotifyCustomer(order);
        }
    }
}
