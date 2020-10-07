using System;

namespace sem_04_Task_3._1
{
    class Program
    {
        static void Method(int n)
        {
            // Создание зубчатой матрицы.
            char[][] matrix = new char[n][];
            for(int i=0; i<n; i++)
            {
                matrix[i] = new char[i + 1];
            }
            // Заполнение матрицы символами.
            for(int i = 0; i < n; i++)
            {
                for(int j=0; j<matrix[i].Length; j++)
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
            if(int.TryParse(input, out int n))
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
