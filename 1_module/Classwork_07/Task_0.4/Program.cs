using System;
using System.Threading;

namespace Task_0._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] matrix = new int[n];
            int[] underzero = new int[n];
            int[] other = new int[n];
            Random rnd = new Random();
            int m = 0;
            int count = 0;
            for(int i=0; i<n; i++)
            {
                matrix[i] = rnd.Next(-10, 11);
                if (matrix[i] < 0)
                {
                    underzero[m] = matrix[i];
                    m++;
                }
                else
                {
                    other[count] = matrix[i];
                    count++;
                }
                Console.Write("{0} ", matrix[i]);
            }
            Console.WriteLine();
           for(int i=count+1; i <n; i++)
            {
                matrix[i] = underzero[i];
            }
           for(int i=0; i <= count; i++)
            {
                matrix[i] = other[i];
            }
           for(int i =0; i<matrix.Length; i++)
            {
                Console.Write("{0}, ", matrix[i]);
            }
        }
    }
}
