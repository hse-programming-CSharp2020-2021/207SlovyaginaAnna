using System;
using System.Runtime.Serialization.Formatters;

namespace Homework_04
{
    class Program
    {
        //Метод вычисляющий сумму первого ряда до машинного нуля.
        static double Method1(double x)
        {
            double s = x * x;
            double flag = 0;
            int n = 3;
            int m = 4;
            double y = 0;
            while (true)
            {
                flag = s;
                // Переменная для проверки того, отличается ли вычесленное значение от предыдущего.
                y = Math.Pow(2, n) * Math.Pow(x, m);
                for(int i=1; i<=m; i++)
                {
                    y /= i;
                }
                s -= y;
                if (flag == s)
                {
                    break;
                }
                m += 2;
                n += 2;
                flag = s;
                y = Math.Pow(2, n) * Math.Pow(x, m);
                for (int i = 1; i <= m; i++)
                {
                    y /= i;
                }
                s += y;
                if (flag == s)
                {
                    break;
                }
                m += 2;
                n += 2;
            }
            return s;
        }

        //Метод вычисляющий сумму второго ряда до машинного нуля.
        static double Method2(double x)
        {
            double flag = 0;
            // Переменная для проверки того, отличается ли вычесленное значение от предыдущего.
            double sum = 1;
            int k = 1;
            double y;
            while (true)
            {
                flag = sum;
                y = Math.Pow(x, k);
                for (int i = 1; i <= k; i++)
                {
                    y /= i;
                }
                sum += y;
                if (flag == sum)
                {
                    break;
                }
                k++;

            }
            return sum;
        }
            static void Method()
            {
                Console.WriteLine("Write x:");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double x))
                {
                    Console.WriteLine(Method1(x));
                    Console.WriteLine(Method2(x));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        
        static void Main(string[] args)
        {
            Method();
            while (true)
            {
                Console.WriteLine("If you want to finish the program enter 0, else enter another number:");
                string str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }
                else
                {
                    Method();
                }
            }
        }
    }
}
