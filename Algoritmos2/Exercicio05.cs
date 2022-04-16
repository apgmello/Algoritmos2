using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio05()
        {
            Console.WriteLine("Ler dois valores e mostrar se são iguais ou qual é o maior");

            double valorA, valorB;

            Console.Write("Digite o primeiro valor: ");
            valorA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valorB = Convert.ToDouble(Console.ReadLine());

            if (valorA == valorB)
            {
                Console.WriteLine("Os valores são iguais");
            }
            else if (valorA < valorB)
            {
                Console.WriteLine("O primeiro valor é menor que o segundo valor");
            }
            else
            {
                Console.WriteLine("O primeiro valor é maior que o segundo valor");
            }
            Console.ReadKey();
        }
    }
}