using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_04
{

    class Program
    {
        static bool Shift(ref char ch)
        {
            bool f = false;
            if (ch >= 120)
            {
                ch = (char)((3-(122 - (int)ch)) + 97);
                f = true;
            }
            else
            {
                ch = (char)(ch + 3);
                f = true;
            }
            return f;
            
        }
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            if(char.TryParse(str, out  char a))
            {
                Shift(ref a);
                Console.WriteLine( a);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
