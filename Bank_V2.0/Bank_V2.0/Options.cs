using System;
using Manipulations;
using Service;

namespace Main
{
    class Options
    {
        private Services services = new Services();

        public void Option()
        {
            Color.YellowColor();
            Console.Write("Opção: "); Color.DefaultColor();
            ServicesManipulations.VerifyPath();
            int option = int.Parse(Console.ReadLine());
            ExecOption(option);
        }

        private void ShowOptionSelected(int option)
        {
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Color.GreenColor(); Console.WriteLine("Opção selecionada: [Cadastrar Cliente] "); Color.DefaultColor();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    Color.GreenColor(); Console.WriteLine("Opção selecionada: [Sacar] "); Color.DefaultColor();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    Color.GreenColor(); Console.WriteLine("Opção selecionada: [Depositar] "); Color.DefaultColor();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    Color.GreenColor(); Console.WriteLine("Opção selecionada: [Mostrar Saldo] "); Color.DefaultColor();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine();
                    Color.RedColor(); Console.WriteLine("Opção selecionada: [Sair] "); Color.DefaultColor();
                    Console.WriteLine();
                    break;
            }
        }

        private void ExecOption(int option)
        {


            switch (option)
            {
                case 1:
                    ShowOptionSelected(option);
                    Console.Write("Escreva seu nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Escreva seu cpf: ");
                    string registry = Console.ReadLine();
                    services.RegisterClients(name, registry);
                    AskAgain();
                    break;
                case 2:
                    ShowOptionSelected(option);
                    break;
                case 3:
                    ShowOptionSelected(option);
                    break;
                case 4:
                    ShowOptionSelected(option);
                    break;
                case 5:
                    ShowOptionSelected(option);
                    break;
            }

        }

        public void AskAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Você deseja escolher outra opção? ");
            Console.Write("Sim/Não: ");
            string response = Console.ReadLine();
            ControllerAskAgain(response);

        }

        private void ControllerAskAgain(string response)
        {
            Menu menu = new Menu();
            Options options = new Options();
            if (response.ToLower() == "sim")
            {
                Console.Clear();
                Console.WriteLine(menu);
                options.Option();
                
            }
            else if (response.ToLower() == "não")
            {
                Console.Clear();
                options.ExecOption(5);
                
            }
            else
            {
                Console.WriteLine();
                Color.RedColor(); Console.WriteLine("Opção inválida, repita: "); Color.DefaultColor();
                string response2 = Console.ReadLine();
                ControllerAskAgain(response2);
            }
        }

    }
}
