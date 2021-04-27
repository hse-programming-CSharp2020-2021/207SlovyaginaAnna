using System;
using System.Collections.Generic;

namespace Task_3
{
    class Evens
    {
        int min;
        int max;
        public Evens(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = min; i <= max; i++)
                if (i % 2 == 0) yield return i;
        }
    }
    class Program
    {
        static void Main()
        {
            Evens ev = new Evens(20, 43);

            foreach (var t in ev)

                Console.Write(t + "  ");

            Console.WriteLine();

            Console.ReadKey();

        } 
    }
}
