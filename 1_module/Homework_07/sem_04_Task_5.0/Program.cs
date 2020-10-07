using System;

namespace sem_04_Task_5._0
{
    class Program
    {
        // Метод создающий двумерный массив и выводящий указанные элементы на экран.
        static void Method(int n)
        {
            Random rnd = new Random();
            int[,] matrix = new int[n, n];
            for(int i=0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 26);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j && i < n - j - 1)
                    {
                        Console.Write("{0}  ", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j && i >= n - j - 1)
                    {
                        Console.Write("{0}  ", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i > j && i > n - j - 1)|| (i < j && i < n - j - 1))
                    {
                        Console.Write("{0}  ", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (((j-i>1||j-i>2)&&j>n/2&&i>n/2 )|| ((i-j>1||i-j>2)&& j < n / 2 && i < n / 2))
                    {
                        Console.Write("{0}  ", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n))
            {
                Method(n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
