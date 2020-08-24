using System;
using ExercicioPropostoHerancaePolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoHerancaePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commom, used or imported (c/u/i): ");
                char resp = char.Parse(Console.ReadLine());
                resp.ToString().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customs));
                }
                else if(resp == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if(resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach(Product prod in list)
                Console.WriteLine(prod.PriceTag());

        }
    }
}
