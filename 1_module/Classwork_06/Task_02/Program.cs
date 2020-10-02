using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Method(int n)
        {
            int[] massive = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                massive[i] = rnd.Next(-10, 11);
                Console.Write("" + massive[i] + " ");
            }
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (massive[i] % 2 != 0)
                {
                    massive[m++] = massive[i];
                }
            }
            if (m > 0)
            {
                Array.Resize(ref massive, m);
                for (int i = 0; i < m; i++)
                {
                    Console.Write("" + massive[i] + " ");
                }

            }
        }
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                Method(n);
            }
        
    }
}
