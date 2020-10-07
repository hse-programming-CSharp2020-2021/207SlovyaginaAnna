using System;
using System.Reflection.Metadata;

namespace sem_04_Task_2._0
{
    class Program
    {
        static void Method(int k, int n)
        {
            int m = 0;
            // Создаем зубчатый массив.
            int[][] matrix = new int[k][];
            for (int i = 0; i < k - 1; i++)
            {
                matrix[i] = new int[i + 1];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = n - m;
                    m++;
                    Console.Write("{0}  ", matrix[i][j]);
                }
                Console.WriteLine();
            }
            matrix[k - 1] = new int[n - m];
            for (int j = 0; j < matrix[k - 1].Length; j++)
            {
                matrix[k - 1][j] = n - m;
                m++;
                Console.Write("{0}  ", matrix[k - 1][j]);
            }
        }
        // Считаем количество элементов в массиве.
        static int Count(int n)
        {
            int k = 1;
            while (n > 0)
            {
                n -= k;
                k++;
            }
            return k-1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n))
            {
                Method(Count(n), n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
