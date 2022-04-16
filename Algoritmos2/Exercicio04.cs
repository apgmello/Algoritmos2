using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio04()
        {
            Console.WriteLine("Ler um valor e escrever se é positivo, negativo ou zero.");

            double valorA;

            Console.Write("Digite um valor: ");
            valorA = Convert.ToDouble(Console.ReadLine());

            if (valorA == 0)
            {
                Console.WriteLine("Valor Zero");
            }
            else if (valorA < 0)
            {
                Console.WriteLine("Valor negativo");
            }
            else
            {
                Console.WriteLine("Valor positivo");
            }

            Console.ReadKey();          
        }
    }
}