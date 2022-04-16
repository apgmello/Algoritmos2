using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio08()
        {
            Console.WriteLine("O exercico 08, corresponde também aos exercicos 9 e 10.\n" +
                "Reescreva o exercicio 7 usando While, informe se o segundo valor for zero\n" +
                "e dê para o usuario a opção de fazer uma nova divisão");

            bool continuar = false;
            double valor1, valor2 = 0;

            do
            {
                Console.Write("Digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                while (valor2 == 0)
                {
                    Console.Write("Digite o segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    if (valor2 == 0)
                    {
                        Console.WriteLine("O segundo valor não pode ser zero!");
                    }
                }
                Console.WriteLine($"O resultado da divisão é {Math.Round(valor1 / valor2, 2)}");

                Console.Write("Deseja efetuar uma nova divisão? (S/N): ");
                continuar = Console.ReadLine() == "S";
                valor2 = 0;
            }
            while (continuar);

        }
    }
}