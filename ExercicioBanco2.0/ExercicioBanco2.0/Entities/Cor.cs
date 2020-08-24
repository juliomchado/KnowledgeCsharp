using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Cor
    {
        public static void AbrirCor (string cor)
        {
            cor.ToLower();
            if (cor == "alert")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (cor == "ok")
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ResetColor();
        }

        public static void FecharCor()
        {
            Console.ResetColor();
        }
    }
}
