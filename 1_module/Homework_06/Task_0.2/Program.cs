using System;

namespace Task_0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            for(int i=0; i<n; i++)
            {
                n -= i;
                m += 1;
            }
            int[][] massive= new int[m][];

        }
    }
}
