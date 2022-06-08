using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ TRABALHANDO COM MATRIZ ------");
            Console.WriteLine("Digite um número (1 a 10)");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua matriz terá {num} linhas e {num} colunas.");

            double [,] mat = new double [num,num];

            for(int i = 0; i < num; i++)
            {
                string[] vetores = Console.ReadLine().Split(' ');

                for (int j = 0; j < num; j++)
                {
                    mat[i, j] = double.Parse(vetores[j]);
                }
            }

            Console.WriteLine("--- MATRIZ DIAGONAL ---");
            for(int i = 0; i < num; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < num; i++)
            {

                for (int j = 0; j < num; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Números negativos = {count}");
        }
    }
}
