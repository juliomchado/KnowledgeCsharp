using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDia17do09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO:");
            Console.ForegroundColor = ConsoleColor.White;
            {
                //Exercício 01
                int indice = 0;
                int[] array = new int[10];
                Random random = new Random();

                Console.WriteLine("While:");

                while (indice < 10)
                {
                    array[indice] = random.Next(0, 100);

                    Console.WriteLine(array[indice]);

                    indice++;
                }
                Console.WriteLine();
                Console.WriteLine("PRESS ENTER"); Console.ReadKey();
                Console.WriteLine();

                //Exercíco 02

                Console.WriteLine("Foreach:");

                foreach (var lerVetor in array) { Console.WriteLine(lerVetor); }
                Console.WriteLine();
                Console.WriteLine("PRESS ENTER"); Console.ReadKey();
                Console.WriteLine();

                //Exercício 03

                Console.WriteLine("Lendo os índices pares utilizndo For:");

                for (var index = 0; index < array.Length; index++)
                {
                    if (index % 2 == 0)
                    {
                        Console.WriteLine($"Índice: {index} || vetor no índice par:{array[index]}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("PRESS ENTER"); Console.ReadKey();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STRUCT & MÉTODOS:");
            Console.ForegroundColor = ConsoleColor.White;
            {
                //Exercício 01
                DadosAlunos[] vetor = new DadosAlunos[10];
                string lerDataDeNascimento = " ";
                int matricula;

                for (var indice = 0; indice < vetor.Length; indice++)
                {
                    Console.Write("Digite o nome do aluno: ");
                    vetor[indice].nome = Console.ReadLine();

                    Console.Write("Digite a idade do aluno: ");
                    vetor[indice].idade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o dia em que o aluno fez aniversário: ");
                    vetor[indice].dia = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o mês em que o aluno fez aniversário: ");
                    vetor[indice].mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(VerificaDataNascimento(vetor[indice].idade, vetor[indice].dia, vetor[indice].mes, lerDataDeNascimento));

                    Console.Write("Digite a matrícula do aluno: ");
                    vetor[indice].matricula = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o código do curso do aluno: ");
                    vetor[indice].codigoDoCurso = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(VerificaCodigoMatricula(vetor[indice].codigoDoCurso));
                    Console.WriteLine();
                }

                //Letra C & D

                Console.WriteLine("Digite a matrícula: ");
                matricula = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Letra D
                for (var indice = 0; indice < vetor.Length; indice++)
                {
                    if (vetor[indice].matricula == matricula)
                    {
                        Console.WriteLine("Nome: " + vetor[indice].nome);
                        Console.WriteLine("Idade: " + vetor[indice].idade);
                        Console.WriteLine("Matrícula: " + vetor[indice].matricula);
                        Console.WriteLine(VerificaCodigoMatricula(vetor[indice].codigoDoCurso));
                        Console.WriteLine("Data de nascimento: " + VerificaDataNascimento(vetor[indice].idade, vetor[indice].dia, vetor[indice].mes, lerDataDeNascimento));
                    }
                }
                Console.WriteLine();

                //Letra C
                for (var indice = 0; indice < vetor.Length; indice++)
                {
                    Console.WriteLine("Indice encontrado com matrícula: " + MetodoDeIndiceMatricula(vetor[indice].matricula, indice, matricula));
                }
                Console.WriteLine();
                Console.WriteLine("PRESS ENTER"); Console.ReadKey();
                Console.WriteLine();
            }
        }
        public struct DadosAlunos
        {
            //Criando métodos para armazenar dados de alunos no vetor.
            public string nome;
            public int idade;
            public int dia;
            public int mes;
            public int matricula;
            public int codigoDoCurso;
        }
        static string VerificaCodigoMatricula(int codigo)
        {
            //Letra A
            if (codigo == 98001)
            {
                string leitor = $"Código {codigo} válido!\nCurso: C++";
                return leitor;
            }
            else if (codigo == 98002)
            {
                string leitor = $"Código {codigo} válido!\nCurso: C#";
                return leitor;
            }
            else if (codigo == 98003)
            {
                string leitor = $"Código {codigo} válido!\nCurso: C";
                return leitor;
            }
            else if (codigo == 98004)
            {
                string leitor = $"Código {codigo} válido!\nCurso: Python";
                return leitor;
            }
            else
            {
                string leitor = "Código inválido!";
                return leitor;
            }
        }
        public static string VerificaDataNascimento(int Idade, int dia, int mes, string leitura)
        {
            //Letra B
            //Obs.: tive dificuldade e o código não está como pedido.
            int Anos = Idade;

            int Ano = DateTime.Now.Year;

            int mesComparacao = DateTime.Now.Month;

            if (mes > mesComparacao)
            {
                Ano = Ano - 1;
            }
            Idade = Ano - Anos;

            int AnoDeNascimento = Idade;

            return Convert.ToString(leitura = $"{dia}/{mes}/{AnoDeNascimento}");
        }
        static string MetodoDeIndiceMatricula(int verifica, int indice, int matricula)
        {
            //Letra C
            if (verifica == matricula)
            {
                return Convert.ToString(indice);
            }
            else
            {
                string leitor = " ";
                return leitor;
            }
        }
    }
}