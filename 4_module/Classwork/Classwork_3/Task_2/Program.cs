using System;
using System.Collections.Generic;

namespace Task_2
{
    class Fibbonacci
    {
        int curr = 1;
        int prev = 0;
        public IEnumerable<int> NextMemb(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int t = curr;
                curr += prev;
                prev = t;
                yield return curr;
            }
        }
    }
    class TriangleNums
    {
        internal IEnumerable<int> NextMemb(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return (i * (i + 1)) / 2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fi = new Fibbonacci();
            TriangleNums tn = new TriangleNums();
            int[] sum = new int[7];
            int cnt = 0;
            foreach (int numb in fi.NextMemb(7))
            {
                Console.Write(numb + " ");
                sum[cnt++] = numb;
            }
            Console.WriteLine();
            cnt = 0;
            foreach (int numb in tn.NextMemb(7))
            {
                Console.Write(numb + " ");
                sum[cnt++] += numb;
            }
            Console.WriteLine();
            foreach (int numb in sum)
            {
                Console.Write(numb + " ");
            }
            Console.WriteLine();
        }
    }
}
