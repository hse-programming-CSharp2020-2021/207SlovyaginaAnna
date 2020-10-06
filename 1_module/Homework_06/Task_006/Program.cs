using System;

namespace Task_006
{
    class Program
    {
        static void Method(int n)
        {
            Random rnd = new Random();
            int[] matrix = new int[n];
            int count = 0;
            // Цикл заполнения массива.
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = rnd.Next(-10, 11);
                Console.Write("{0} ", matrix[i]);
            }
            // Цикл удаления элементов из массива.
            while (true)
            {
                for (int j = 0; j < matrix.Length - 1; j++)
                {
                    int countOld = 0;
                    if (matrix[j] % 3 == 0 && matrix[j + 1] % 3 == 0)
                    {
                        count++;
                        countOld++;
                        matrix[j] = matrix[j] * matrix[j + 1];
                        for (int k = j + 2; k < matrix.Length; k++)
                        {
                            matrix[k - 1] = matrix[k];
                        }
                    }
                    if (countOld > 0)
                    {
                        Array.Resize(ref matrix, n-countOld);
                    }
                    else
                    {
                        break;
                    }

                }

                foreach (int m in matrix)
                {
                    Console.Write("{0} ", matrix[m]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            // Введение длины массива.
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n) && n > 0)
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
