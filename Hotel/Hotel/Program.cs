using System;

namespace Hotel // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- SISTEMA DE HOSPEDAGEM -----");
            Console.WriteLine("---------------------------------");

            //Array de Quartos



            Console.WriteLine("Quantos quartos vão ser alugados ? (1-10) ");
            int num = Int32.Parse(Console.ReadLine());

            //tamanho de quarto fixo
            Quarto[] Quarto = new Quarto[10];




            for (int i = 0 ; i < num; i++)
            {
                Console.WriteLine("--- CADASTRO DE QUARTOS ---");
                Console.WriteLine(" - Dados de Aluguel -  ");
                Console.WriteLine("Digite seu nome: ");
                string name = Console.ReadLine();

                Console.WriteLine("Digite seu e-mail: ");
                string mail = Console.ReadLine();

                Console.WriteLine("Digite o número do quarto que você deseja alugar: ");
                int numQuarto = Int32.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------||-------------------------------");

                Quarto[numQuarto] = new Quarto(name, mail, numQuarto);
                Console.Clear();
            }


            Console.WriteLine("----- RElATÓRIO DE OCUPAÇÃO -----");

            for (int i = 0; i < Quarto.Length; i++)
            {
                if (Quarto[i] != null)
                {
                    Console.WriteLine("Quarto # " + Quarto[i].Numeracao);
                    Console.WriteLine("Nome do ocupante : " + Quarto[i].NomeAluguel);
                    Console.WriteLine("E-mail do ocupante: " + Quarto[i].Email);
                    Console.WriteLine("---------------------------------------------");

                }

            }

            //TRATAMENTO DE ERROS






        }
    }
}
