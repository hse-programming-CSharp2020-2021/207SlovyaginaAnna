using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[5][];
            Random rnd = new Random();
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                k = rnd.Next(5, 9);
                a[i] = new int[k];
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    k = rnd.Next(-10, 11);
                    a[i][j] = k;
                    Console.Write(""+a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
