using System;

namespace BoxingeUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {   //Boxing (Converte de um objeto do tipo valor para um objeto tipo referência compatível)
             int x = 20; 
            Object obj = x; 

            //Unboxing (Converte de um objeto tipo referência para um objeto do tipo valor compatível)
            int x2 = 20;
            Object obj2 = x;

            int y = (int) obj2;
        }
    }
}
