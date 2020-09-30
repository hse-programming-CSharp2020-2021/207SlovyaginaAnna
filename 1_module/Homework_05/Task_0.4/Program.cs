using System;

namespace Task_0._1
{
    class Program
    {
        // Метод создающий и заполняющий массив.
        static void Method(int n)
        {
            double[] numbers = new double[n];
            numbers[0] = 1;
            numbers[1] = 1;
            Console.Write("" + numbers[0] + " "+numbers[1]+" ");
            for (int i = 2; i < n ; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
                Console.Write("" + numbers[i] + " ");
            }
        }

        // Метод для ввода данных.
        static void Method1()
        {
            Console.WriteLine("Write N:");
            string inp = Console.ReadLine();
            if (int.TryParse(inp, out int n) && n > 1 )
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
