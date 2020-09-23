using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._4
{
    class Program
    {
        static void Method(int a1, int a2, int a3)//Метод выводящий наименьший номер или номера комнат на этажах
        {
            int a=0;
            if ((a1/100 == a2/100) && (a2/100 == a3/100))
            {
                 a = (a1 < a2) ?( (a1 < a3 )? a1 : (a2 < a3 )? a2 : a3):0;
            }
            else
            {
                if(a1 / 100 == a2 / 100)
                {
                    a = a1 < a2 ? a1 : a2; 
                }
                if (a1 / 100 == a3 / 100)
                {
                    a = a1 < a3 ? a1 : a3;
                }
                if (a3 / 100 == a2 / 100)
                {
                    a = a3 < a2 ? a3 : a2;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Room 1: {0}, room 2: {1}, room 3: {2}", a1 % 100, a2 % 100, a3 % 100);
            }
            else
            {
                Console.WriteLine("Min room: {0}", a % 100);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write the 1 room:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write the 2 room:");
            string inp2 = Console.ReadLine();
            Console.WriteLine("Write the 3 room:");
            string inp3 = Console.ReadLine();
            if(int.TryParse(inp1, out int r1)&&int.TryParse(inp2, out int r2)&&int.TryParse(inp3, out int r3))
            {
                Method(r1, r2, r3);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
