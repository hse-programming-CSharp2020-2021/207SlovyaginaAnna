using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static int Method()//Метод находящий трехзначное число состоящие из одинаковых цифр
        {
            int a = 0;
            
            for(int i=1; i <10; i++)
            {
                int s = 0;
                int j = 0;
                while(s<= i * 100 + i * 10+i)
                {
                    if(s== i * 100 + i * 10 + i)
                    {
                        a = s;
                        break;
                    }
                    else
                    {
                        j += 1;
                        s += j;
                    }
                }
            }
            return (a);
        }
        static void Main(string[] args)
        {
            int b = Method();
            if (b == 0)
            {
                Console.WriteLine("Не найдено");
            }
            else
            {
                Console.WriteLine(b);
            }

        }
    }
}
