using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] massive = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if (i == j) { massive[i, j] = 0; }
                    if (i > j && i != j) { massive[i, j] = -1; }
                    else { if (i != j) { massive[i, j] = 1; } }
                    Console.Write("{0}  ", massive[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
