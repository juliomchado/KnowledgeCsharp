using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Entities;
using System.Globalization;
using Main;
using System.Linq;

namespace Manipulations
{
    class ServicesManipulations : Controllers
    {
        private const string Path = @"C:\Bank\", Files = "ClientsBrazil.txt";
        public static void VerifyPath()
        {
            if (!(Directory.Exists(Path)))
            {
                Directory.CreateDirectory(Path);
                VerifyQntRegistry = 1;
                StreamWriter sw = new StreamWriter(Path + Files);
                sw.Write(string.Empty);
                sw.Close();
            }
        }

        public static void VerifyAccExists(int option, string name, string registry)
        {
            List<BrazilClient> list = new List<BrazilClient>();
            Options options = new Options();

            ReadFiles();
            if (option == 1)
            {
                int contador = 0;
                var names = list.Where(p => p.Name == name || p.Cpf == registry);
                foreach (BrazilClient obj in names)
                {
                    Console.WriteLine($"{obj} {contador = 1}");
                }
                if (contador == 1)
                {
                    WriterFiles(1, name, registry);
                }
                else
                {
                    Color.RedColor(); Console.WriteLine("Sua conta já existe, desculpe"); Color.DefaultColor();
                    options.AskAgain();
                }

            }

        }



        public static void WriterFiles(int option, string name, string registry, double saldo = 0.0)
        {
            List<BrazilClient> list = new List<BrazilClient>();
            switch (option)
            {
                case 1:
                    using (StreamWriter sr = File.AppendText(Path + Files))
                    {
                        foreach (BrazilClient obj in list)
                        {
                            sr.WriteLine(obj);
                            Console.WriteLine($"Escrevendo no arquivo: {obj}");
                        }
                    }
                    VerifyRegistry(name, registry, DateTime.Now, saldo);
                    break;
            }
        }

        public static void VerifyRegistry(string name, string registry, DateTime date, double saldo = 0.0)
        {
            List<BrazilClient> list = new List<BrazilClient>();
            Options options = new Options();

            int contador = 0;

            var names = list.Where(p => p.Name == name && p.Cpf == registry && p.Date == date);
            foreach (BrazilClient verify in names)
            {
                if (verify == names)
                {
                    contador++;
                }
            }

            if (contador > 0)
            {
                Color.GreenColor(); Console.WriteLine($"A sua conta foi registrada com sucesso!! Nome: {name}, Cpf: {registry}, Saldo: R${saldo}, criado as {date}"); Color.DefaultColor();
                options.AskAgain();
                contador = 0;
            }
            else
            {
                Color.RedColor(); Console.WriteLine($"Desculpe, ocorreu algum erro e sua conta não foi registrada"); Color.DefaultColor();
                options.AskAgain();
            }
        }

        public static void ReadFiles()
        {
            List<BrazilClient> list = new List<BrazilClient>();

            using (StreamReader sr = File.OpenText(Path + Files))
            {
                string[] text = sr.ReadLine().Split(";");
                while (!sr.EndOfStream && text[0] != null)
                {

                    string name = text[0];
                    string registry = text[1];
                    double balance = double.Parse(text[2], CultureInfo.InvariantCulture);
                    DateTime date = DateTime.Parse(text[3]);
                    list.Add(new BrazilClient(name, registry, balance, date));
         

                }

                foreach(BrazilClient obj in list)
                {
                    Console.WriteLine(obj.ToString());
                }
            }

        }
    }
}


