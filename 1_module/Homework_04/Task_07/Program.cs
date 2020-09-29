using System;
using System.Data;
using System.Xml;

namespace Task_07
{
    class Program
    {
        // Метод поиска НОД и НОК
        static void Method( uint a,  uint b, out uint nod, out uint nok)
        {
            nok = a * b;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
              nod = a;
              nok = nok / nod;
        }

        // Метод для организации повтора решения.
        static void Method1()
        {
            Console.WriteLine("Write A:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write B:");
            string inp2 = Console.ReadLine();
            if (uint.TryParse(inp1, out uint a) && uint.TryParse(inp2, out uint b))
            {
                uint nod = 0;
                uint nok = 0;
                Method(a, b, out nod, out nok);
                Console.WriteLine("NOD: " + nod);
                Console.WriteLine("NOK: " + nok);
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
                Console.WriteLine("If you want to finish the program enter 0, else enter another number:");
                string str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }
                else
                {
                    Method1();
                }
            }

        }
    }
}
