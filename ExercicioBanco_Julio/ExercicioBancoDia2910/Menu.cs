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
    class Menu
    {
        public void Opcoes(int opcoes)
        {
            Cliente[] cliente = new Cliente[10000];
            Conta conta = new Conta();

            while (opcoes != null)
            {
                switch (opcoes)

                {
                    case 1:

                        Console.Write("Escreva seu nome: ");
                        string Nome = Console.ReadLine();
                        Console.Write("Escreva seu cpf: ");
                        string Cpf = Console.ReadLine();
                        double Saldo = 0.00;

                        CadastroDoCliente(Nome, Cpf, Saldo);

                        Console.WriteLine();

                        Console.Write(MensagensMenu().Replace("Escolha quais opções você quer:\n" +
                        "--------------------------------------\n" +
                        "1 - Caso queira cadastrar\n", "Escolha novamente qual opção você quer:\n" +
                        "--------------------------------------\n" + "1 - Caso queira cadastrar outra conta\n"));

                        opcoes = int.Parse(Console.ReadLine());
                        break;



                    case 2:
                        Console.Write("Digite o seu cpf: ");
                        Cpf = Console.ReadLine();
                        Console.Write("Digite a quantidade que você quer sacar: ");
                        Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        conta.Saque(Cpf, Saldo);
                        Console.WriteLine();
                        Console.Write(MensagensMenu().Replace("Escolha quais opções você quer:\n" +
                        "--------------------------------------\n" +
                        "2 - Caso queira sacar\n", "Escolha novamente qual opção você quer:\n" +
                        "--------------------------------------\n" + "2 - Caso queira sacar outro valor\n"));

                        opcoes = int.Parse(Console.ReadLine());
                        break;

                    case 3:

                        Console.Write("Digite o seu cpf: ");
                        Cpf = Console.ReadLine();
                        Console.Write("Digite a quantidade que você quer depositar: ");
                        Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        conta.Deposito(Cpf, Saldo);

                        Console.WriteLine();
                        Console.Write(MensagensMenu().Replace("Escolha quais opções você quer:\n" +
                        "--------------------------------------\n" +
                        "3 - Caso queira depositar\n", "Escolha novamente qual opção você quer:\n" +
                        "--------------------------------------\n" + "3 - Caso queira fazer outro deposito\n"));

                        opcoes = int.Parse(Console.ReadLine());
                        break;

                    case 4:


                        Console.Write("Digite seu cpf: ");
                        Cpf = Console.ReadLine();

                        MostrarSaldo(Cpf);

                        Console.WriteLine();
                        Console.Write(MensagensMenu().Replace("Escolha quais opções você quer:\n" +
                        "--------------------------------------\n" +
                        "4 - Caso queira ver seu saldo em conta\n" + "5 - Caso queira sair\n", "Escolha novamente qual opção você quer:\n" +
                        "--------------------------------------\n" + "" + "4 - Caso queira sair\n"));

                        opcoes = int.Parse(Console.ReadLine());
                        break;
                }

                if (opcoes == 5)
                {
                    Console.WriteLine();
                    Console.Write("Você saiu, obrigado e volte sempre !!", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();

                    break;
                }

                if (opcoes < 1 || opcoes > 5)
                {
                    Console.WriteLine();
                    Console.Write("Não existe essa opção, por favor aperte outra", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("Opção: ");
                    opcoes = int.Parse(Console.ReadLine());
                    break;
                }

            }

        }


        public void CadastroDoCliente(string nome, string cpf, double saldo)
        {

            Cliente[] cliente = new Cliente[10000];
            bool criacaocontas = false;
            string pasta = @"C:\ContasDoBanco\", arquivo = "Cliente.txt";

            string[] conteudo;
            string linha;
            int contador = 0;
            int permissao = 0;

            

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
                StreamWriter CriarPasta = new StreamWriter(pasta + arquivo);
                CriarPasta.Write("");
                CriarPasta.Close();
            }
            
            

            

            StreamReader LerDados = new StreamReader(pasta + arquivo);


            while ((linha = LerDados.ReadLine()) != null)
            {
                conteudo = linha.Split(';');

                cliente[contador].Nome = conteudo[0];
                cliente[contador].Cpf = conteudo[1];
                cliente[contador].Saldo = double.Parse(conteudo[2], CultureInfo.InvariantCulture);
                contador++;
            }
            LerDados.Close();

            for (contador = 0; contador < cliente.Length; contador++)
            {
                if (cliente[contador].Nome == nome || cliente[contador].Cpf == cpf)
                {
                    Console.WriteLine();
                    Console.WriteLine("Desculpe, seus dados já estão registrados", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    break;
                }
                else
                {


                    StreamWriter EscreverArquivo = File.AppendText(pasta + arquivo);
                    EscreverArquivo.WriteLine($"{nome};{cpf};{saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                    EscreverArquivo.Close();

                    Console.WriteLine();
                    Console.WriteLine($"Cliente: {nome} dono do cpf: {cpf} cadastrado com sucesso!!", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                    EscreverArquivo.Close();
                    break;
                }

            }


        }




        public string MensagensMenu()
        {


            return "Escolha quais opções você quer:\n" +
                "--------------------------------------\n" +
                "1 - Caso queira cadastrar\n" +
                "2 - Caso queira sacar\n" +
                "3 - Caso queira depositar\n" +
                "4 - Caso queira ver seu saldo em conta\n" +
                "5 - Caso queira sair\n" +
                "--------------------------------------\n" +
                "\nOpção:  ";

        }




        public void MostrarSaldo(string cpf)
        {
            string pasta = @"C:\ContasDoBanco\", arquivo = "Cliente.txt";
            Cliente[] cliente = new Cliente[10000];
            int contador = 0;
            string[] conteudo;
            string linha;

            StreamReader LerDados = new StreamReader(pasta + arquivo);

            while ((linha = LerDados.ReadLine()) != null)
            {
                conteudo = linha.Split(';');

                cliente[contador].Nome = conteudo[0];
                cliente[contador].Cpf = conteudo[1];
                cliente[contador].Saldo = double.Parse(conteudo[2], CultureInfo.InvariantCulture);
                contador++;
            }
            LerDados.Close();

            for (contador = 0; contador < cliente.Length; contador++)
            {
                if (cliente[contador].Cpf == cpf)
                {
                    Console.WriteLine();
                    Console.WriteLine($"O saldo de {cliente[contador].Nome}, Dono do cpf {cliente[contador].Cpf}, Tem um saldo de: R${cliente[contador].Saldo.ToString("F2", CultureInfo.InvariantCulture)}", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                    break;
                }
                else if (contador < cliente.Length && cliente[contador].Cpf == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("O seu cpf não está cadastrado.", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    break;
                }

            }
        }


    }
}






