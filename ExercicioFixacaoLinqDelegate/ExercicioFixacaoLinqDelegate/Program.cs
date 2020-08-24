using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ExercicioFixacaoLinqDelegate.Entities;
using System.Globalization;

namespace ExercicioFixacaoLinqDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] cont = sr.ReadLine().Split(',');
                    string name = cont[0];
                    string email = cont[1];
                    double salar = double.Parse(cont[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salar));
                }
            }
            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            var sla = list.Where(p => p.Salary > 2000.00).OrderBy(p => p.Name).Select(p => p.Email);
            foreach(string email in sla)
            {
                Console.WriteLine(email);
            }

            var sla2 = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M': " + sla2);


        }
    }
}
