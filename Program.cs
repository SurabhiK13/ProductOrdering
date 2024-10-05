using System;
using Test2Product;
using System;

public class ProductOutOfStockException : Exception
{
    public override string Message => "Product Out Of Stock";
}
public class Program
{
    public static void Main(string[] args)
    {
        DeliveryService deliveryService = new DeliveryService();

        try
        {
            Console.WriteLine("Enter the product name");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the number of stocks");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product product = new Product
            {
                Name = productName,
                Stock = stock
            };

            if (deliveryService.PlaceOrder(product))
            {
                Console.WriteLine("Order placed successfully");
            }
        }
        catch (ProductOutOfStockException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}