using System;

namespace Task_0._1
{
    class Program
    {
        // Метод создающий и заполняющий массив.
        static void Method(int n)
        {
            int k = 1;
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = k;
                Console.Write("" + numbers[i] + " ");
                k += 2;
            }
        }
        static void Method1()
        {
            Console.WriteLine("Write N:");
            string inp = Console.ReadLine();
            if (int.TryParse(inp, out int n) && n > 0)
            {
                Method(n);
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
