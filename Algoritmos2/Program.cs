using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int numeroExercicio = -1;

            while (numeroExercicio != 0)
            {
                Console.Clear();
                Console.Write("Digite o numero do exercicio (1 a 8, 0 = sair): ");
                numeroExercicio = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (numeroExercicio == 1)
                {
                    Exercicio01();
                }
                else if (numeroExercicio == 2)
                {
                    Exercicio02();
                }
                else if (numeroExercicio == 3)
                {
                    Exercicio03();
                }
                else if (numeroExercicio == 4)
                {
                    Exercicio04();
                }
                else if (numeroExercicio == 5)
                {
                    Exercicio05();
                }
                else if (numeroExercicio == 6)
                {
                    Exercicio06();
                }
                else if (numeroExercicio == 7)
                {
                    Exercicio07();
                }
                else if (numeroExercicio == 8)
                {
                    Exercicio08();
                }
                else if (numeroExercicio > 8)
                {
                        Console.WriteLine("Opção invalida");
                        Console.ReadKey();                    
                }
            }
        }
    }
}





