using System;

namespace sem_04_Task_1._3
{
    class Program
    {
        static void Method(int[,] matrix, int n)
        {
            int k = 1;
            int i1 = 0;
            int j1 = 0;
            int m1 = n - 1;
            int l1 = n - 1;
            while (k<=n*n)
            {
                for (int j = j1; j < n - j1 - 2; j++)
                {
                    matrix[i1, j] = k;
                    k++;
                    Console.Write("{0}  ", matrix[i1, j]);
                    if (k == n * n) { break; }
                }
                Console.WriteLine();
                for (int i = i1; i < n - i1 - 1 - 1; i++)
                {
                    matrix[i, n - j1 - 1] = k;
                    k++;
                    Console.Write("{0}  ", matrix[i, n-j1-1]);
                    if (k == n * n) { break; }
                }
                Console.WriteLine();
                for (int m = m1; m > n - 1 - m1 +1; m--)
                {
                    matrix[l1, m] = k;
                    k++;
                    Console.Write("{0}  ", matrix[l1,m]);
                    if (k == n * n) { break; }
                }
                Console.WriteLine();
                for (int l = l1; l > n - 1 - l1 + 1; l--)
                {
                    matrix[l, i1] = k;
                    k++;
                    Console.Write("{0}  ", matrix[l, i1]);
                    if (k == n * n) { break; }
                }
                Console.WriteLine();
                i1++;
                j1++;
                l1--;
                m1--;
            }
            for (int z = 0; z < n; z++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write("{0}   ", matrix[z, x]);
                }
                Console.WriteLine();
            }
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n) && n > 0)
            {
                int[,] matrix = new int[n, n];
                Method(matrix, n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
