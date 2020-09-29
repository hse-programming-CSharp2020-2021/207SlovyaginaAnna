using System;
using System.Security.Cryptography.X509Certificates;

namespace IndependentWork_03
{
    class Program
    {
        // Метод табулирующий функцию.
        static void function(int a, int b, int c)
        {
            double x = 1;
            while (x < 1.2)
            {
                Console.WriteLine("x={0:F3}; f(x)={1}", x, a * x * x + b * x + c);
                x += 0.05;
            }
            Console.WriteLine("x={0:F3}; f(x)={1}", 0.05, a / x + Math.Sqrt(x * x + 1));
            x += 0.05;
            while (x<=2)
            {
                    Console.WriteLine("x={0:F3}; f(x)={1}", x, (a + b * x) / Math.Sqrt(x * x + 1));
                x += 0.05;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write A:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write B:");
            string inp2 = Console.ReadLine();
            Console.WriteLine("Write C:");
            string inp3 = Console.ReadLine();
            if(int.TryParse(inp1, out int a)&&int.TryParse(inp2, out int b)&&int.TryParse(inp3, out int c))
            {
                function(a, b, c);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
