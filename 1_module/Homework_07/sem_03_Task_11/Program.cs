using System;

namespace sem_03_Task_11
{
    class Program
    {
        // Метод создающий, заполняющий и выводящий массив.
        static void Method(int n)
        {
            int[] matrix = new int[n];
            matrix[0] = 0;
            matrix[1] = 1;
            for(int i=2;i<n; i++)
            {
                matrix[i] = 34 * matrix[i - 1] - matrix[i - 2] + 2;
            }
            for(int i=0; i < n; i++)
            {
                Console.WriteLine(matrix[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n)&&n>0)
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
