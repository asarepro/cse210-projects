using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
//     }
// }

class Program {
    static void Main(string[] args) {
        var address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        var customer1 = new Customer("Jane Doe", address1);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W123", 10.99, 2));
        order1.AddProduct(new Product("Gadget", "G456", 5.49, 3));

        var address2 = new Address("456 King St", "Toronto", "ON", "Canada");
        var customer2 = new Customer("John Smith", address2);

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamabob", "T789", 12.99, 1));
        order2.AddProduct(new Product("Doohickey", "D012", 7.99, 4));

        DisplayOrder(order1);
        Console.WriteLine("\n---\n");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order) {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost():0.00}");
    }
}