using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._3
{
    class Program

    {
        static void G(double x)//Метод, выводящий значение функции.
        {
            if (x <= 0.5)
            {
                Console.WriteLine(Math.Sin(Math.PI / 2));
            }
            else
            {
                Console.WriteLine(Math.Sin(Math.PI * (x - 1) / 2));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write x:");
            string inp1 = Console.ReadLine();
            if (double.TryParse(inp1, out double a) )
            {
                G(a);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
