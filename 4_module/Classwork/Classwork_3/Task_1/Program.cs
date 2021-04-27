using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Fibbonacci fi = new Fibbonacci();
        foreach (int numb in fi.NextMemb(7))
            Console.Write(numb + " ");
        Console.WriteLine();
        foreach (int numb in fi.NextMemb(7))
            Console.Write(numb + " ");
        Console.WriteLine();
    }
    class Fibbonacci
    {
        int curr = 1;
        int prev= 0;
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
}
