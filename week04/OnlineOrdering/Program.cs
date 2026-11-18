using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
       "123 Main Street",
       "Orlando",
       "Florida",
       "USA"
    );

        Customer customer1 = new Customer("John Smith", address1);

        Address address2 = new Address(
        "Avenida Leitão da Silva, 1387",
        "Vitória",
        "Espírito Santo",
        "Brazil"
    );

        Customer customer2 = new Customer("Maria Santos", address2);

        Product product1 = new Product("Keyboard", "K123", 25.50m, 2);
        Product product2 = new Product("Mouse", "M456", 15.00m, 1);
        Product product3 = new Product("Monitor", "MN789", 150.00m, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Product product4 = new Product("Headphones", "H123", 80.00m, 1);
        Product product5 = new Product("Webcam", "W456", 45.00m, 2);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}