using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_0._7
{
    class Program
    {
        static void Method(int a1, int b1, int c1)//Метод вычисляющий значение или значения квадратного уравнения
        {
            bool flag = false;
            if (a1 == 0 && b1 == 0)
            {
                Console.WriteLine(flag);
            }
            else
            {
                double discriminant = b1 * b1 - 4 * a1 * c1;
                if(discriminant < 0)
                {
                    Console.WriteLine("No solution");
                }
                if (discriminant == 0)
                {
                    Console.WriteLine("x={0}",-b1/(2*a1));
                }
                if (discriminant > 0)
                {
                    Console.WriteLine("x1={0}\r\nx2={1}", (-b1 + Math.Sqrt(discriminant)) / (2 * a1), (-b1 - Math.Sqrt(discriminant)) / (2 * a1));
                }
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
                Method(a, b, c);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

        }
    }
}
