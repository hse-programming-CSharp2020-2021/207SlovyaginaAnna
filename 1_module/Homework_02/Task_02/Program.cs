using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static int Divide1(int a)//Возвращает последнюю цифру числа
        {
            int a1 = a % 10;
            return a1; 
            
        }
        static int Divide2(int a)//Возвращает первую цифру числа
        {
            int a2 = (int)(a / 100);
            return a2;
        }
        static int Divide3(int a)//Возвращает среднюю цифру числа
        {
            int a3 = ((int)(a / 10) % 10);
            return a3;
        }
        static void Sort(int min, int medium, int max)//Ссортирует цифры и выводит максимальное число
        {
            int a= max > medium ? (max > min ? max: medium > min ? medium : min):(medium>min?medium:min);
            int b = max < medium ? (max < min ? max : medium < min ? medium : min) : (medium<max?medium:max);
            int c = (a!=min)&&(b!=min)?min:((a!=medium)&&(b!=medium)?medium:max);
            int k = (100 * a + 10 * c + b);
            Console.WriteLine("Максимальное число: " + k);
        }
        static void Repeat()//Цикл повторения решения
        {
            Console.WriteLine("Введите трехзначное число: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int p))
            {
                Console.WriteLine("Error");
            }
            else
            {
                Sort(Divide1(p), Divide2(p), Divide3(p));
            }
        }
        static void Main(string[] args)
        {
            Repeat();
            while (true)
            {
                Console.WriteLine("Для повтора введите next для завершения stop ");
                string str = Console.ReadLine();
                if (str == "next")
                {
                    Repeat();
                }
                if (str == "stop")
                {
                    break;
                }
            }
        }
    }
}
