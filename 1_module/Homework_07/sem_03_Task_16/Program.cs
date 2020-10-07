using System;

namespace sem_03_Task_16
{
    class Program
    {
        static void Method(int n)
        {
            // Создание массива из заданного числа элементов.
            int[] matrix = new int[n];
            Random rnd = new Random();
            int min = 10;
            int max = -10;
            int minIndex = 0;
            int maxIndex = 0;
            for(int i=0; i<matrix.Length; i++)
            {
                matrix[i] = rnd.Next(-10, 11);
                // Поиск максимального элемента и его индекса.
                if (matrix[i] > max)
                {
                    max = matrix[i];
                    maxIndex = i;
                }
                // Поиск минимального элемента и его индекса.
                if (matrix[i] < min)
                {
                    min = matrix[i];
                    minIndex = i;
                }
            }
            foreach(int m in matrix) { Console.Write("{0}  ", m); }
            Console.WriteLine();
            Console.WriteLine("Index of min element = {0}\r\nIndex of min element + Index of max element = {1}", minIndex, minIndex + maxIndex);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
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
