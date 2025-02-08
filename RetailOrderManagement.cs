using System;
namespace RetailOrderManagement
{
    class Order
    {
        public int OrderId;
        public DateTime OrderDate;

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        // Virtual method to get order status
        public virtual string GetOrderStatus()
        {
            return "Order placed.";
        }

        // Method to display order details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
        }
    }

    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        // Override GetOrderStatus method
        public override string GetOrderStatus()
        {
            return "Order shipped.";
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Tracking Number: {TrackingNumber}");
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        // Override GetOrderStatus method
        public override string GetOrderStatus()
        {
            return "Order delivered.";
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Delivery Date: {DeliveryDate.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(12, DateTime.Now.AddDays(-10));
            Console.WriteLine("Order Details:");
            order.DisplayDetails();
            Console.WriteLine($"Status: {order.GetOrderStatus()}");
            Console.WriteLine();

            ShippedOrder shippedOrder = new ShippedOrder(13, DateTime.Now.AddDays(-5), "TRK123456");
            Console.WriteLine("Shipped Order Details:");
            shippedOrder.DisplayDetails();
            Console.WriteLine($"Status: {shippedOrder.GetOrderStatus()}");
            Console.WriteLine();

            DeliveredOrder deliveredOrder = new DeliveredOrder(14, DateTime.Now.AddDays(-7), "TRK654321", DateTime.Now.AddDays(-2));
            Console.WriteLine("Delivered Order Details:");
            deliveredOrder.DisplayDetails();
            Console.WriteLine($"Status: {deliveredOrder.GetOrderStatus()}");
        }
    }
}
