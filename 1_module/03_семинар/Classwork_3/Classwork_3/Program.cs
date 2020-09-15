using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_3
{
    class Program
    {
        public static void M1(int a)
        {
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("удовлетворительно");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Хорошо");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Uncorrect");
                    break;

            }
        }
       
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int c;
            if (int.TryParse(inp, out c)){
                M1(c);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
