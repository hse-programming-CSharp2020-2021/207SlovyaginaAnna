using System;

namespace Task_8._1
{
    class Program
    {
        // Метод создает, заполняет и выводит массив.
        // Метод находит максимальное значение элемента массива и делит на него все остальные элементы.
        // Затем выводит измененный массив.
        static void Method(int n)
        {
            double max = 0;
            double[] massiv = new double[n];
            for(int i=0; i < n; i++)
            {
                massiv[i] =((double) (i * (i + 1)) / 2)%n;
                if (massiv[i] > max)
                {
                    max = massiv[i];
                }
                Console.Write(" " + massiv[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                massiv[i] = (double)massiv[i] / max;
                Console.Write(" {0:F3}", massiv[i]);
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
