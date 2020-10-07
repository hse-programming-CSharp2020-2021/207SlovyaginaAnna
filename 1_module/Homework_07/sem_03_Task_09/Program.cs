using System;

namespace sem_03_Task_09
{
    class Program
    {
        static void ArrayHill(int[] A)
        {
            // Сортируем массив от меньшего элемента к большему.
            Array.Sort(A);
            for(int i=0; i<A.Length; i++)
            {
                Console.Write("   {0} = {1}  ", i, A[i]);
            }
            Console.WriteLine();
            int l = 0;
            int m = 1;
            // Цикл сдвигающий все необходимые элементы на 1 влево а нужный перемещающий в конец.
            for (int i = 1; i<A.Length/2; i++)
            {
                l = A[i];
                for(int j=i; j<A.Length-m; j++)
                {
                    A[j] = A[j + 1];
                }
                A[A.Length - m]=l;
                m++;
            }
            if (A.Length % 2 != 0)
            {
                l = A[A.Length / 2 + 1];
                A[A.Length / 2 + 1] = A[A.Length / 2];
                A[A.Length / 2] = l;
            }
            // Вывод получившегося массива.
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("   {0} = {1}  ", i, A[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n)&& n > 0)
            {
                int[] A = new int[n];
                Random rnd = new Random();
                for(int i = 0; i<A.Length; i++)
                {
                    A[i] = rnd.Next(-10, 11);
                    Console.Write("   {0} = {1}  ", i, A[i]);
                }
                Console.WriteLine();
                ArrayHill(A);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
