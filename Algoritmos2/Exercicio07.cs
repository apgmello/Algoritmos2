using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio07()
        {
            Console.WriteLine("Escreva um algoritmo para ler 2 valores e se o segundo valor informado for\n" +
            "ZERO, deve ser lido um novo valor, ou seja, para o segundo valor não pode ser\n" +
            "aceito o valor zero e imprimir o resultado da divisão do primeiro valor lido pelo\n" +
            "segundo valor lido. (utilizar a estrutura REPITA).\n");

            double valor1, valor2 = 0;

            Console.Write("Digite o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.Write("Digite o segundo valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());
                if (valor2 == 0)
                {
                    Console.WriteLine("O segundo valor não pode ser zero!");
                }
            }
            while (valor2 == 0);

            Console.WriteLine($"O resultado da divisão é {Math.Round(valor1 / valor2, 2)}");
            Console.ReadKey();
        }
    }
}