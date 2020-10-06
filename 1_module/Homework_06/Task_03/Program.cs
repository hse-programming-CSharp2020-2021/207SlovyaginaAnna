using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle,
            x,
            sin,
            sinOld,
            memb;
            Console.WriteLine("Write angle:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out angle))
            {
                // Перевод угла.
                x = angle % (2 * Math.PI);
                int m;
                for(m=1,sin=memb=x, sinOld=0;sin!=sinOld; m++)
                {
                    // Вывод подсчитанных значений.
                    Console.WriteLine("sin({0})={1} \tmemb={2}", x, sin, memb);
                    sinOld = sin;
                    memb *= -x * x / 2 / m / (2 * m + 1);
                    sin += memb;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
