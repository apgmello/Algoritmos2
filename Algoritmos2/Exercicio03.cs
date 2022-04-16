using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio03()
        {
            Console.WriteLine("Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em\n" +
            "estoque e quantidade mínima em estoque de um produto.\n" +
            "Calcular e escrever a quantidade média(quantidade média = quantidade máxima +\n" +
            "quantidade mínima) / 2).\n" +
            "Se a quantidade em estoque for maior ou igual a quantidade média escrever a mensagem\n" +
            "'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'.\n");

            int quantidadeMaxima = 3000;
            int quantidadeMinima = 1000;
            int quantidadeMedia;
            int quantidadeAtual;

            Console.WriteLine("Qual a quantidade atual do estoque: ");
            quantidadeAtual = Convert.ToInt32(Console.ReadLine());

            quantidadeMedia = (quantidadeMaxima - quantidadeMinima) / 2;

            if (quantidadeAtual > 3000)
            {
                Console.WriteLine("Quantidade superior ao limite do estoque");
            }
            else if (quantidadeAtual >= quantidadeMedia)
            {
                Console.WriteLine("Não efetuar compra");
            }
            else
            {
                Console.WriteLine("Efetuar compra");
            }
            Console.ReadKey();
        }
    }
}