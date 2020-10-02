using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Method(int n)
        {
            int k = 0;
            int m = n;
            while (m > 0)
            {
                k += 1;
                m /= 10;
            }
            char[] massive = new char[k];
            for(int i =k-1; i>=0; i--)
            {
                massive[i] = (char)(n % 10);
                n /= 10;
            }
            for(int i=0; i<k; i++)
            {
                Console.Write("" + massive[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            int n = int.Parse(Console.ReadLine());
            Method(n);
        }
    }
}
