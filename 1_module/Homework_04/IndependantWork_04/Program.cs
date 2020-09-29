using System;

namespace IndependantWork_04
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            Console.WriteLine("Write M:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write N:");
            string inp2 = Console.ReadLine();
            if (int.TryParse(inp1, out int m) && int.TryParse(inp2, out int n))
            {
                int a = b << m;
                // Возведение двойки в степень m.
                int c = b << n;
                // Возведение двойки в степень n.
                Console.WriteLine(c+a);
            }
            else

            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
