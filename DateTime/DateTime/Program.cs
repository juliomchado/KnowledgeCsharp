using System;
using System.Globalization;

namespace AulaDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); //Definir o formato de impressão

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);


            /*
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");


            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            */


            //Construtores
            /* 
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            */

            //Builders
            /*
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today; //Data atual do sistema com horas 00
            DateTime d6 = DateTime.UtcNow; //Horario de agora no GNT (Horario Universal).
            */

            /*
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            */

           /* DateTime d1 = DateTime.Now; //Horario atual do sistema
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //Quantidade de ticks desde o dia 1 de janeiro as 00:00 da era atual até hoje (100nanosegundos)
            */


        }

    }
}
