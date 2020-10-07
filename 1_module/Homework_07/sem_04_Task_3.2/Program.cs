using System;

namespace sem_04_Task_3._2
{
    class Program
    {
        // Метод, создающий, заполняющий и выводящий массив.
        static void Method(int n)
        {
            // Создание зубчатого массива.
            char[][] matrix = new char[n][];
            for(int i = 0; i<n; i++)
            {
                matrix[i] = new char[n / 2 + i];
            }
            int m = 1;
            for (int i = 0; i <= n/2-1; i++)
            {
                    for (int j = matrix[i].Length - 1; j >= matrix[i].Length - m; j--)
                    {
                        matrix[i][j] = '*';
                    }
                    m += 2;
                
                for(int j =0; j<matrix[i].Length; j++)
                {
                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine();
            }
            for(int i=n/2; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = '*';
                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                Method(n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
