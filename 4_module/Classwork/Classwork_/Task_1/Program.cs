using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            var randomSeq = Enumerable.Repeat(0, n).Select(i => rand.Next(-1000, 1001)).ToArray();
            foreach (int x in randomSeq)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            var lastLetter = randomSeq.Select(x => Math.Abs(x) % 10);
            foreach (int x in lastLetter)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            var group = randomSeq.GroupBy(x => x % 10);
            Console.WriteLine(group);
            Console.WriteLine();
            try
            {
                var evenPositive = randomSeq.Where(x => x > 0 && x % 2 == 0).Aggregate((i, j) => i + j);
                Console.WriteLine(evenPositive);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            var sort = randomSeq.OrderBy(x => x / Math.Pow(10, Math.Log(x))).ThenBy(x => Math.Abs(x) % 10);
            foreach (int x in sort)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

        }
    }
}
