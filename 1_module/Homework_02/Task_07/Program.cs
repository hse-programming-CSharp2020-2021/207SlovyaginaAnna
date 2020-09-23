using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        static void Divide(double a)
        {
            int b = (int)a;
            Console.WriteLine("Целая часть - {0}, дробная часть - {1:f3}", b, (a - b));
        }
        static void Sq(double a)
        {
            double b = a * a;
            double c = Math.Sqrt(a);
            Console.WriteLine("Квадрат числа - {0:f3}, квадратный корень числа - {1:f3}", b, c);
        }
        static void Main(string[] args)
        
        {
            Console.WriteLine("Введите дробное число: ");
            string inp = Console.ReadLine();
            if(double.TryParse(inp, out double x))
            {
                Divide(x);
                Sq(x);
            }
            else
            {
                Console.WriteLine("Error");
            }
            while (true)
            {
                Console.WriteLine("Для повтора введите next, для завершения stop:");
                string str = Console.ReadLine();
                if (str == "next")
                {
                    Console.WriteLine("Введите дробное число: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double z))
                    {
                        Divide(z);
                        Sq(z);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
                else
                {
                    break;
                }
            }
        }
    }
}
