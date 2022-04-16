using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio06()
        {
            Console.WriteLine("Escreva um algoritmo que leia as idades de 2 homens e de 2 mulheres (considere\n" +
        "que as idades dos homens serão sempre diferentes entre si, bem como as das\n" +
        "mulheres).\n" +
        "Calcule e escreva a soma das idades do homem mais velho com a mulher mais nova, e o\n" +
        "produto das idades do homem mais novo com a mulher mais velha.\n");

            int nova, velho;

            int mulher1, mulher2, homem1, homem2;

            int soma;

            Console.Write("Digite a idade do 1° mulher: ");
            mulher1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade do 2° mulher: ");
            mulher2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade do 1° homem: ");
            homem1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade do 2° homem: ");
            homem2 = Convert.ToInt32(Console.ReadLine());

            if (mulher1 < mulher2)
            {
                nova = mulher1;
            }
            else
            {
                nova = mulher2;
            }

            if (homem1 > homem2)
            {
                velho = homem1;
            }
            else
            {
                velho = homem2;
            }

            soma = velho + nova;

            Console.WriteLine($"A soma da idade do homem mais velho e da mulher mais nova é: {soma}");

            Console.ReadKey();
            
        }
    }
}