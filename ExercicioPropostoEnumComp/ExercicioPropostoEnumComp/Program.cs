using System;
using System.Globalization;
using ExercicioPropostoEnumComp.Entities.Enums;
using ExercicioPropostoEnumComp.Entities;

namespace ExercicioPropostoEnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write($"Name: ");
            string name = Console.ReadLine();
            Console.Write($"Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qntItems = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, orderStatus, client);
            
            for(int n = 1; n <= qntItems; n++)
            {
                Console.WriteLine($"Enter #{n} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, priceProd);
                OrderItem orderitem = new OrderItem(quantity, priceProd, product);
                order.AddItems(orderitem);

            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
