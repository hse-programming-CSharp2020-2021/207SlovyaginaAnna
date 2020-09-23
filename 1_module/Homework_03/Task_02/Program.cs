using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    class Program
    {
        static string Method(string a)//Метод создающий строку из чисел числа идущих в обратном порядке
        {
            string outp ="";
            if(int.TryParse(a, out int b))
            {
                if(b%10 == 0)
                {
                    b = b / 10;
                }
                while(b!=0)
                
                {
                    outp += (b % 10);
                    b = b / 10;
                }
            }
            return (outp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            string inp = Console.ReadLine();
            if (int.TryParse(inp, out int c))
            {
                string str = Method(inp);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
