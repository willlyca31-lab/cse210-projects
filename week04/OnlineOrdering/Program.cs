using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>();

        products1.Add(new Product("Laptop", "P100", 800, 1));
        products1.Add(new Product("Mouse", "P101", 25, 2));

        Order order1 = new Order (customer1, products1);

        Address address2 = new Address(
            "456 Maple Road",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Maria Lopez", address2);

        List<Product> products2 = new List<Product>();

        products2.Add(new Product("Phone", "P200", 600, 1));
        products2.Add(new Product("Headphones", "P201", 50, 2));

        Order order2 = new Order(customer2, products2);

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}