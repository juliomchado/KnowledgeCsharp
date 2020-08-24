using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Principais;
using Entities;
using System.Globalization;

namespace ManipularArquivos
{
    abstract class Manipulacoes
    {
        public string Pasta = @"C:\Banco\";
        public string Arquivo  = @"Dados.txt";
        public Cliente[] cliente = new Cliente[10000];
        public Solicitacoes soli;
        

        public Manipulacoes(string pasta, string arquivo)
        {
            Pasta = pasta;
            Arquivo = arquivo;
        }

        public void VerificarExistenciaPasta()
        {

            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
                using (StreamWriter sw = new StreamWriter(Pasta + Arquivo))
                {
                    sw.Write(string.Empty);
                }
            }

        }


        public void RecarregarStruct()
        {
            VerificarExistenciaPasta();

            Cliente[] cliente = new Cliente[10000];
            using (StreamReader sr = new StreamReader(Pasta + Arquivo))
            {
                string linha;
                string[] conteudo;
                int contador = 0;

                while ((linha = sr.ReadLine()) != null)
                {
                    conteudo = linha.Split(';');
                    cliente[contador].Nome = conteudo[0];
                    cliente[contador].Cpf = conteudo[1];
                    cliente[contador].Saldo = double.Parse(conteudo[2], CultureInfo.InvariantCulture);
                    contador++;
                }
            }
        }

        
        public void EscreverNaPasta(string nome, string cpf, double quantia)
        {
            
            RecarregarStruct();
            StreamWriter sw1 = new StreamWriter(Pasta + Arquivo);
            sw1.Write(string.Empty);
            sw1.Close();

            using (StreamWriter sw = File.AppendText(Pasta + Arquivo))
            {
                if (soli.verificacao == true)
                {
                    sw.WriteLine($"{nome}, {cpf}, {quantia}");
                }
                
            }

        }


    }
}
