using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio01()
        {
            Console.WriteLine("Escreva um programa que solicite ao usuário a sua idade e armazene na variável\n" +
            "A.Em seguida solicite ao usuário o ano que ele nasceu e armazene na variável B.\n" +
            "Em seguida(utilizando apenas atribuições entre variáveis) troque os conteúdos fazendo\n" +
            "com que o valor que está em A passe para B e vice - versa.\n" +
            "Ao final, escreva na tela o valor da variável A e em seguida da variável B.)\n");

            int valorA; //idade
            int valorB; //ano
            int valorGuardado;

            Console.Write("Qual a sua idade: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o ano do seu nascimento: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            valorGuardado = valorA;
            valorA = valorB;
            valorB = valorGuardado;

            Console.WriteLine($"A ordem contrária dos valores informados é: {valorA} e {valorB}");

            Console.ReadKey();
        }
    }
}