using System;
using System.Linq;

namespace sem_03_Task_20
{
    class Program
    {
        static void ArrayItemDouble(ref int[] A, int x)
        {
            int count = 0;
            // Подсчет элементов массива равных х.
            for(int i=0; i<A.Length;i++)
            {
                if (A[i] == x)
                {
                    count++;
                }
            }
            Console.WriteLine("Count = {0}", count);
            // Увеличения размера массива на число равное количеству элементов х в массиве.
            Array.Resize(ref A,  A.Length + count);
            Console.WriteLine("New Length = {0}", A.Length);
            Console.WriteLine();
            // Цикл который при нахождении элемента равного х сдвигает все последующие элементы на единицу а следующему элементу после х присваивает значение х.
            for(int i = 0; i < A.Length - count; i++)
            {
                if (A[i] == x)
                {
                    for(int j = A.Length-1; j>i; j--)
                    {
                        A[j] = A[j - 1];
                    }
                    A[i + 1] = x;
                }
                
            }
            // Вывод на экран полученного массива.
            foreach(int m in A) { Console.Write("{0}  ", m); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            Console.WriteLine("Write Y:");
            string input1 = Console.ReadLine();
            if(int.TryParse(input, out int n)&&int.TryParse(input1, out int x) && n > 0)
            {
                int[] A = new int[n];
                Random rnd = new Random();
                // Сщздание и заполнение массива рандомными числами.
                for(int i = 0; i < A.Length; i++)
                {
                    A[i] = rnd.Next(10, 101);
                    Console.Write("{0}  ",  A[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                ArrayItemDouble(ref A, x);
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}
