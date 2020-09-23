using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void check()//Проверяет выполняется ли равенство треугольников
        {
            Console.WriteLine("Введите 1 число с использованием запятой а не точки:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Введите 2 числос использованием запятой а не точки:");
            string inp2 = Console.ReadLine();
            Console.WriteLine("Введите 3 числос использованием запятой а не точки:");
            string inp3 = Console.ReadLine();
            if (double.TryParse(inp1, out double a) && double.TryParse(inp2, out double b) && double.TryParse(inp3, out double c))
            {
                bool p1 = a + b > c ? true : false;
                bool p2 = a + c > b ? true : false;
                bool p3 = b + c > a ? true : false;
                while ((p1 != false) && (p2 != false) && (p3 != false))
                {
                    Console.WriteLine("Равенство треугольника выполняется");
                    break;
                }
                while ((p1 = false) && (p2 = false) && (p3 = false))
                {
                    Console.WriteLine("Равенство треугольника не выполняется");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Main(string[] args)
        {
            check();
            while (true)
            {
                Console.WriteLine("Для повтора введите next для завершения stop ");
                string str = Console.ReadLine();
                if (str == "next")
                {
                    check();
                }
                if (str == "stop")
                {
                    break;
                }
            }
        }
    }
}
