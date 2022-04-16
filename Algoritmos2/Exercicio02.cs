using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio02()
        {
            Console.WriteLine("Tendo como dados de entrada (solicitado ao usuário) o nome, a altura e o sexo\n" +
            "(M ou F) de uma pessoa, calcule e mostre seu peso ideal, utilizando as seguintes\n" +
            "fórmulas:\n" +
            "- para sexo masculino: peso ideal = (72.7 * altura) - 58\n" +
            "- para sexo feminino: peso ideal = (62.1 * altura) – 44.7\n");

            string nome;
            double altura;
            string sexo;
            double imc;

            Console.Write("Qual o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Qual a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o seu sexo - F ou M: ");
            sexo = Console.ReadLine().ToUpper();

            if (sexo == "M")
            {
                imc = (altura * 72.7) - 57;
            }
            else
            {
                imc = (altura * 62.1) - 44.7;
            }

            Console.WriteLine($"{nome} o seu peso ideal é {Math.Round(imc, 2)}");

            Console.ReadKey();
        }
    }
}