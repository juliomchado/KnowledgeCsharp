using System;
using System.Globalization;
using ExercicioPropostoException.Entities;
using ExercicioPropostoException.Entities.Exception;

namespace ExercicioPropostoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double iniBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double whithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.Write("Enter amount for whithdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, iniBalance, whithdrawLimit);
                acc.Withdraw(withdraw);

                Console.WriteLine(acc);
            }
            catch(LimitException e)
            {
                Console.WriteLine("Withdrawn error: " + e.Message);
            }
        }
    }
}
