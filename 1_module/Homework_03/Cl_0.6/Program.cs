using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_04
{
    class Program
    {
        static void Method(double a, double b, uint c)//Метод выводящий таблицу значений итоговых сумм
        {
            double s=0;
            for(int i=1;i<c+1; i++)
            {
                Console.WriteLine(i + ".   " + (a + a * b / 100));
                a = (a + a * b / 100);
                 s+= a;
            }
            Console.WriteLine("Общая сумма : {0}", s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Процент:");
            string inp2 = Console.ReadLine();
            Console.WriteLine("Количесво лет:");
            string inp3 = Console.ReadLine();
            if (double.TryParse(inp1, out double k) && double.TryParse(inp2, out double r) && uint.TryParse(inp3, out uint n)&&k>0&&r>0&&n>0)
            {
                Method(k, r, n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
