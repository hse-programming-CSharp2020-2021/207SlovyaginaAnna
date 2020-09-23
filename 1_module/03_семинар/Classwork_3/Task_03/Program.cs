using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write delta:");

            string inp2 = Console.ReadLine();
            double delta = 0;
            double a;
            double s = 0.0;
            double k = 0;
            int i;
            if (double.TryParse(inp1, out a) || double.TryParse(inp2, out delta))
            {
                for (i = 1; (i * delta) < a; i++)
                {
                    s += (delta / 2) * (Math.Pow(i * delta, 2.0) + Math.Pow((i - 1) * delta, 2.0));
                    k += 1;
                }

                
            }
            else
            {
                Console.WriteLine("Error");
            }
            s += (a - k *delta) * (Math.Pow(k * delta, 2.0) + Math.Pow(a * delta, 2.0)) / 2;
            Console.WriteLine(s);

        }
    }
}
