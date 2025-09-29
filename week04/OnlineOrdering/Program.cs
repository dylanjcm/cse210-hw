using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address intlAddress = new Address("45 Queen St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice Johnson", usaAddress);
        Customer customer2 = new Customer("Carlos Mendes", intlAddress);

        // Create products
        Product p1 = new Product("Laptop", "L1001", 1200.00m, 1);
        Product p2 = new Product("Mouse", "M2002", 25.00m, 2);
        Product p3 = new Product("Keyboard", "K3003", 45.00m, 1);

        Product p4 = new Product("Headphones", "H4004", 60.00m, 1);
        Product p5 = new Product("Webcam", "W5005", 80.00m, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        Order order2 = new Order(customer2);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // Display order details
        List<Order> orders = new List<Order> { order1, order2 };

        int count = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"Order #{count}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
            Console.WriteLine("-----------------------------------\n");
            count++;
        }
    }
}
