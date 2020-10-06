using System;

namespace Task_004
{
    class Program
    {
        // Метод считающий количество элементов массива.
        static int Count(uint a0)
        {
            int k = 1;
            uint a=0;
            while (a != 1)
            {
                a = a0 % 2 == 0 ? a0 / 2 : (3 * a0 + 1);
                a0 = a;
                k++;
            }
            return k;
        }

        // Метод формирования и вывода массива.
        static void Method(int k, uint a0)
        {
            uint[] matrix = new uint[k];
            matrix[0] = a0;
            for(int i =1; i<matrix.Length; i++)
            {
                matrix[i] = matrix[i - 1] % 2 == 0 ? matrix[i - 1] / 2 : (3 * matrix[i - 1] + 1);
            }
            for(int i = 1; i < matrix.Length+1; i++)
            {
                Console.Write("[{0}] = {1}   ", i - 1, matrix[i - 1]);
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write A:");
            string input = Console.ReadLine();
            if(uint.TryParse(input, out uint a0))
            {
                Method(Count(a0), a0);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
