using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioBancoDia2910;
using System.IO;
using System.Globalization;


namespace ExercicioBancoDia2910
{
    class Conta
    {


        public void Saque(string cpf, double saldo)
        {
            Cliente[] cliente = new Cliente[10000];

            string pasta = @"C:\ContasDoBanco\", arquivo = "Cliente.txt";
            string arquivo1 = "Cliente2.txt";
            int contador = 0;

            Menu menu = new Menu();
            StreamReader LerDados = new StreamReader(pasta + arquivo);

            string[] conteudo;
            string linha;


            while ((linha = LerDados.ReadLine()) != null)
            {
                conteudo = linha.Split(';');

                cliente[contador].Nome = conteudo[0];
                cliente[contador].Cpf = conteudo[1];
                cliente[contador].Saldo = double.Parse(conteudo[2], CultureInfo.InvariantCulture);
                contador++;
            }
            LerDados.Close();
            StreamWriter EscreverDados2 = File.AppendText(pasta + arquivo1);

            for (contador = 0; contador < cliente.Length; contador++)
            {

                if (cliente[contador].Cpf != cpf && cliente[contador].Cpf != null)
                {
                    EscreverDados2.WriteLine($"{cliente[contador].Nome};{cliente[contador].Cpf};{cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                    
                }
            }
            EscreverDados2.Close();
            if (saldo > 0)
            {
                for (contador = 0; contador < cliente.Length; contador++)
                {
                    if (cpf == cliente[contador].Cpf && cliente[contador].Saldo == 0)
                    {
                        Console.WriteLine("O seu saldo é igual a 0, você não pode sacar, por favor, faça um depósito antes", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        Console.WriteLine("Escreva sim caso queira fazer um depósito e não caso queira sair.");
                        string resposta = Console.ReadLine();
                        resposta.ToLower();

                        if (resposta == "sim")
                            menu.Opcoes(3);
                        else if (resposta == "não")
                            break;
                        else
                        {
                            Console.WriteLine("Resposta não válida, por favor responda sim ou não.", Console.ForegroundColor = ConsoleColor.Red);
                            resposta = Console.ReadLine();
                            break;
                        }

                    }
                    else if (cliente[contador].Cpf == cpf)
                    {
                        File.Delete(pasta + arquivo);

                        File.Copy(pasta + arquivo1, pasta + arquivo);
                        File.Delete(pasta + arquivo1);

                        StreamWriter EscreverDados = File.AppendText(pasta + arquivo);

                        cliente[contador].Saldo = cliente[contador].Saldo - saldo;
                        EscreverDados.WriteLine($"{cliente[contador].Nome};{cliente[contador].Cpf};{cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        EscreverDados.Close();



                        Console.WriteLine();
                        Console.WriteLine($"O Saldo de {cliente[contador].Nome}, Cpf {cliente[contador].Cpf} agora é de R${cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ResetColor();
                        break;

                    }
                    else
                        continue;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Você não pode sacar um valor menor que 0, digite outro valor", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                double numero = double.Parse(Console.ReadLine());
                Saque(cpf, numero);
                
            }
        }









        public void Deposito(string cpf, double saldo)
        {
            Cliente[] cliente = new Cliente[10000];
            string pasta = @"C:\ContasDoBanco\", arquivo = "Cliente.txt";
            string arquivo1 = "Cliente2.txt";
            int contador = 0;

            Menu menu = new Menu();

            StreamReader LerDados = new StreamReader(pasta + arquivo);
            string[] conteudo;
            string linha;



            while ((linha = LerDados.ReadLine()) != null)
            {
                conteudo = linha.Split(';');

                cliente[contador].Nome = conteudo[0];
                cliente[contador].Cpf = conteudo[1];
                cliente[contador].Saldo = double.Parse(conteudo[2], CultureInfo.InvariantCulture);
                contador++;
            }
            LerDados.Close();
            StreamWriter EscreverDados2 = File.AppendText(pasta + arquivo1);
            if (saldo > 0)
            {
                for (contador = 0; contador < cliente.Length; contador++)
                {

                    if (cliente[contador].Cpf != cpf && cliente[contador].Cpf != null)
                    {
                        EscreverDados2.WriteLine($"{cliente[contador].Nome};{cliente[contador].Cpf};{cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

                    }
                }
                EscreverDados2.Close();

                for (contador = 0; contador < cliente.Length; contador++)
                {
                    if (cliente[contador].Cpf == cpf)
                    {

                        File.Delete(pasta + arquivo);



                        File.Copy(pasta + arquivo1, pasta + arquivo);
                        File.Delete(pasta + arquivo1);

                        StreamWriter EscreverDados = File.AppendText(pasta + arquivo);

                        cliente[contador].Saldo = cliente[contador].Saldo + saldo;
                        EscreverDados.WriteLine($"{cliente[contador].Nome};{cliente[contador].Cpf};{cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        EscreverDados.Close();



                        Console.WriteLine();
                        Console.WriteLine($"O Saldo de {cliente[contador].Nome}, Cpf {cliente[contador].Cpf} agora é de R${cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ResetColor();

                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Você não pode depositar um valor menor que 0, digite outro valor", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                double numero = double.Parse(Console.ReadLine());
                Saque(cpf, numero);
            }

        }

    }
}

