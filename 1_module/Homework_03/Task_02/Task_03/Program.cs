using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static bool G(double x, double y)//Метод проверяющий принадлежит ли точка сектору.
        {
            bool a = false;
            if ((x * x + y * y <= 4) && (x >= 0))
            {
                if((x != 0) && (y / x <= 1))
                {
                    a = true;
                }
                if ((x == 0) && (y <= 0))
                {
                    a = true;
                }
            }
            return (a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write x:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write y:");
            string inp2 = Console.ReadLine();
            if((double.TryParse(inp1, out double a))&&(double.TryParse(inp2, out double b)))
            {
                Console.WriteLine(G(a, b));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

        }
    }
}
