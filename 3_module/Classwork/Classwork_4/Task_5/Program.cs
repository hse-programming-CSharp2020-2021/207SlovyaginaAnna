using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    delegate double Multiple(int i);
    delegate double Sum();
    class Program
    {
        static void Main(string[] args)
        {
            int max = 5;
            double x = 3;
            Multiple mul = i =>
            {
                double p = 1;
                for (int j = 1; j <= max; j++)
                    p = p * i * x / j;
                return p;
            };
            Sum sum = () =>
            {
                double Sum = 0;
                for (int j = 1; j <= max; j++)
                    Sum += mul(j);
                return Sum;
            };
            Console.WriteLine(sum());
            Console.ReadKey();
        }
    }
}

