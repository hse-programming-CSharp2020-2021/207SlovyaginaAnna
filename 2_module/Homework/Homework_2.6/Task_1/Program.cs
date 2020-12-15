using System;

namespace Task_1
{
    public  class Matrix
    {
        // Получение значения целочисленного параметра
        public  int GetIntValue(string comment)
        {
            Console.Write(comment);
            return int.Parse(Console.ReadLine());
        }
        public  void MatrPrint(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for(int j=0; j<ar.GetLength(1); j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public  int[,] UnitMatr(int n)
        {// Сформировать единичную матрицу:
            if (n <= 0)
                throw new ArgumentOutOfRangeException("Аргумент метода должен быть положительным!");
            int[,] ar = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    ar[i, j] = (i == j ? 1 : 0);
            return ar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            int[,] res=new int[0,0]; // ссылка на двумерный массив (матрица)
            int rank; // Порядок матрицы
            do
            { // цикл повторения решений
                try
                {
                    rank= matrix.GetIntValue("Введите порядок матрицы: ");
                    res = matrix.UnitMatr(rank);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (ArgumentNullException e1) {/* TODO */}
                catch (FormatException e2) {/* TODO */}
                catch (OverflowException e3) {/* TODO */}

                Matrix.MatrPrint(res);
                Console.WriteLine("Для завершения программы нажмите ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
