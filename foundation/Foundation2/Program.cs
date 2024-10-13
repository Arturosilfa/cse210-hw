using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("13 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("Arturo Marte", address1);
        Customer customer2 = new Customer("Kenia Silfa", address2);

        
        Product product1 = new Product("Computer", "A123", 999.99m, 1);
        Product product2 = new Product("Mouse", "B456", 25.99m, 2);
        Product product3 = new Product("Keyboard", "C789", 49.99m, 1);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.GetTotalCost()}");
    }
}
