using System;
using Main;
using Manipulations;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Menu menu = new Menu();
             Options options = new Options();
             Console.WriteLine(menu);
             options.Option();

        }
    }
}
