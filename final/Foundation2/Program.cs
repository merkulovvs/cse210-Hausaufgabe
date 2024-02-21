using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("100 N 200 W", "Townone", "Utah", "USA");
        Customer customer1 = new Customer("Mr. Smith", address1);
        Order order1 = new Order();
        order1.SetCustomer(customer1);
        Product product1_1 = new Product("shirt", "001", 45.00, 5);
        order1.SetProduct(product1_1);
        Product product1_2 = new Product("trousers", "002", 60.00, 3);
        order1.SetProduct(product1_2);
        Product product1_3 = new Product("hat", "003", 30, 2);
        order1.SetProduct(product1_3);

        Address address2 = new Address("Erstestrasse 4", "Stadtzwei", "Hessen", "Germany");
        Customer customer2 = new Customer("Herr Smidt", address2);
        Order order2 = new Order();
        order2.SetCustomer(customer2);
        Product product2_1 = new Product("T-Shirt", "004", 37.25, 10);
        order2.SetProduct(product2_1);
        Product product2_2 = new Product("shorts", "005", 35.10, 6);
        order2.SetProduct(product2_2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(" Packing label:");
        order1.GetPackingLable();
        Console.WriteLine($" Shipping label:");
        order1.GetShippingLable();
        Console.WriteLine($" Total price: {order1.GetTotalPrice():0.00}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine($" Packing label:");
        order2.GetPackingLable();
        Console.WriteLine($" Shipping label:");
        order2.GetShippingLable();
        Console.WriteLine($" Total price: {order2.GetTotalPrice():0.00}");
        Console.WriteLine();

    }

}