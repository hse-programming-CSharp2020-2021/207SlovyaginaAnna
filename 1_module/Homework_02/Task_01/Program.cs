using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    class Program
    {
        static int Function(int a,int b)// Метод, возводщий число a в степень b
        {
            int n = 1;
            for(int i=0; i<b; i++)
            {
              n *=a  ;
            }
            return n;

        }
        static void Method() //Метод выводящий значение полиндрома
        {
            Console.WriteLine("Write x: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int x))
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(12 * Function(x, 4) + 9 * Function(x, 3) - 3 * Function(x, 2) + 2 * x - 4);
            }
        }
        static void Main(string[] args)
        {
            Method();
            while (true)//Цикл повторения решения
            {
                Console.WriteLine("Для повтора введите next для завершения stop ");
                string str = Console.ReadLine();
                if (str == "next")
                {
                    Method();
                }
                if (str == "stop")
                {
                    break;
                }
            }
            

            
        }
    }
}
