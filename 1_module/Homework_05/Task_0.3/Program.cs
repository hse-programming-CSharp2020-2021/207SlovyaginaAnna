using System;

namespace Task_0._1
{
    class Program
    {
        // Метод создающий и заполняющий массив.
        static void Method(int n, int a, int d)
        {
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = a+d*i;
                Console.Write("" + numbers[i] + " ");
            }
        }

        // Метод для ввода данных.
        static void Method1()
        {
            Console.WriteLine("Write N:");
            string inp = Console.ReadLine();
            Console.WriteLine("Write A:");
            string inp2 = Console.ReadLine();
            Console.WriteLine("Write D:");
            string inp3 = Console.ReadLine();
            if (int.TryParse(inp, out int n) && n > 1&&int.TryParse(inp2, out int a)&&int.TryParse(inp2, out int d))
            {
                Method(n, a, d);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        static void Main(string[] args)
        {
            Method1();
            while (true)
            {
                Console.WriteLine("If you want to repeat enter 0, else enter another symbol");
                string inp = Console.ReadLine();
                if (inp == "0")
                {
                    Method1();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
