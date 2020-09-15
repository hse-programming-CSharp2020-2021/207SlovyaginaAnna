using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp;
            bool x = false,
                y = false,
                z = false;
            string str;
            Console.WriteLine("Write x: ");
            str = Console.ReadLine();
            if(!int.TryParse(str, out tmp))
            {
                Console.WriteLine("Error");
            }
            else
            {
                x = tmp > 0 ? true : false;
            }
            Console.WriteLine("Write y: ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out tmp))
            {
                Console.WriteLine("Error");
            }
            else
            {
                y = tmp > 0 ? true : false;
            }
            Console.WriteLine("Write z: ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out tmp))
            {
                Console.WriteLine("Error");
            }
            else
            {
                z = tmp > 0 ? true : false;
            }
            Console.WriteLine("!(X&&Y||Z) = " + !(x && y || z));
        }
    }
}
