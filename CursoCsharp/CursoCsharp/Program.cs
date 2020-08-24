using System;

namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             // =============EXERCICIO 1=============
            double codigo1, nPecas1, codigo2, nPecas2;

            double preco1, preco2, calculo;
            Console.WriteLine("Escreva os valores: ");
            codigo1  = Convert.ToDouble(Console.ReadLine()); nPecas1 = Convert.ToDouble(Console.ReadLine()); preco1 = Convert.ToDouble(Console.ReadLine());
            codigo2 = Convert.ToDouble(Console.ReadLine()); nPecas2 = Convert.ToDouble(Console.ReadLine()); preco2 = Convert.ToDouble(Console.ReadLine());

            calculo = (nPecas1 * preco1) + (nPecas2 * preco2);

            Console.WriteLine($"Valor a pagar: R${calculo} ");

            */
            //=============EXERCICIO 1.2=============
            /*
            double raio, Pi = 3.14159, area;
            Console.WriteLine("Valor do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            raio = raio * raio;
            area = Pi * raio;

            Console.WriteLine($"Area = {Math.Round(area, 4).ToString()}");
            */
            //=============EXERCICIO 2.1=============
            /*
            Console.WriteLine("Codigo " + "           Especificação" + "    " + "              Preço   \n" +
                              "1" + "                 Cachorro Quente" + "               R$ 4.00    \n" +
                              "2" + "                 X-Salada" + "                      R$ 4.50    \n" +
                              "3" + "                 X-Bacon" + "                       R$ 5.00    \n" +
                              "4" + "                 Torrada Simples" + "               R$ 2.00    \n" +
                              "5" + "                 Refrigerante" + "                  R$ 1.50    ");
            int codigo, quantidade;
            double valor = 0, calculo;

            Console.WriteLine("\nEscolha o produto:   ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha a quantidade:   ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            if (codigo == 1) {

                valor = 4.00;
            }
            else if (codigo == 2)
            {
                valor = 4.50;
            }
            else if (codigo == 3)
            {
                valor = 5.00;
            }
            else if (codigo == 4)
            {
                valor = 2.00;
            }
            else if (codigo == 5)
            {
                valor = 1.50;
            }
            calculo = (valor * quantidade);
            Console.WriteLine($"Total = R${calculo}  ");
            */
            //=============EXERCICIO 2.2=============
            /*
            double delta, valorB, a, b, c, raiz;
            
            Console.WriteLine("Equação do segundo grau: ");
            Console.WriteLine("Digite o valor de a: "); a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: "); b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: "); c = Convert.ToDouble(Console.ReadLine());

            if (a == 0) {
                Console.WriteLine("Impossivel calcular");
            }


                valorB = b * b;

                delta = valorB - (4 * a * c);
                raiz = Math.Sqrt(delta);

                var x1 = ((-(b)) + raiz) / (2 * a);
                var x2 = ((-(b)) - raiz) / (2 * a);

                if (delta < 0) {

                    Console.WriteLine("Impossivel calcular");
                }

                Console.WriteLine($"Valor de x1: {Math.Round(x1, 5).ToString()}");
                Console.WriteLine($"Valor de x2: {Math.Round(x2, 5).ToString()}");
                */
            //=============EXERCICIO 3=============
            /*
            int senha;
            

            Console.WriteLine("Escreva uma senha: ");
            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.WriteLine("Escreva outra senha: ");
                senha = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Senha válida!! Acesso Permitido");
            
            */
            /*
            int valores, i, numero, calculador1 = 0, calculador2 = 0;
            Console.WriteLine("Escreva quantos valores serão colocados: ");
            
            valores = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Escreva os números: ");
            for (i = 0; i < valores; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 10 && numero <= 20) {
                    calculador1++;
                   
                }
                else 
                {
                    calculador2++;
                }
                
            }
            Console.WriteLine($"{calculador1} in");
            Console.WriteLine($"{calculador2} out");
            */
        }
    }
}
