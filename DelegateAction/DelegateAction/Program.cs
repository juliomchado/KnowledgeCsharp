using System;
using System.Collections.Generic;
using DelegateAction.Entities;

namespace DelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
             Com expressão Lambda
           
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            ou diretamente no list.ForEach

             list.ForEach(p => { p.Price += p.Price * 0.1; };);
            */

            list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
