using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        static void G(double x, double y)
        {
            if ((x < y) && (x > 0))
            {
                Console.WriteLine(x + Math.Sin(y));
            }
            else
            {
                if ((x > y) && (x < 0))
                {
                    Console.WriteLine(y - Math.Cos(x));
                }
                else
                {
                    Console.WriteLine(0.5 * x * y);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write x:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write y:");
            string inp2 = Console.ReadLine();
            if(double.TryParse(inp1, out double a)&&double.TryParse(inp2, out double b))
            {
                G(a, b);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
