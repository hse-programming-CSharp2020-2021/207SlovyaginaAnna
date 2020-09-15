using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void divide()//Метод выводящий цифры четырехзначного числа в обратном порядке
        {
            Console.WriteLine("Введите четырехзначное число: ");
            string inp = Console.ReadLine();
            if(!int.TryParse(inp, out int k))
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("{0} {1} {2} {3}",(int)(k%10), (int)((k/10)%10), (int)((k/100)%10), (int)(k /1000));

            }
        }
        static void Main(string[] args)
        {
            divide();
            while (true)
            {
                Console.WriteLine("Для повтора введите next для завершения stop ");
                string str = Console.ReadLine();
                if (str == "next")
                {
                    divide();
                }
                if (str == "stop")
                {
                    break;
                }
            }
        }
    }
}
