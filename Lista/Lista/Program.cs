using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Aula1
            List<string> lista = new List<string>();
            List<string> lista2 = new List<string> { "Maria", "José" };
            */

            List<string> lista = new List<string>();
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");

            lista.Insert(2, "Marco");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro da lista que começa com A: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima com A: " + s2);

            int posicao1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do 1 que começa com A: " + posicao1);

            int posicao2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição do que começa com A: " + posicao2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }


            lista.RemoveAt(3);
            Console.WriteLine("--------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveRange(2, 2);
            Console.WriteLine("--------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }


            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
