using System;

namespace sem_04_Task_6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание матрицы и заполнение рандомными числами.
            int[,] matrix = new int[3, 6];
            Random rnd = new Random();
            for(int i=0; i < 3; i++)
            {
                for(int j=0; j<6; j++)
                {
                    matrix[i, j] = rnd.Next(0, 21);
                    Console.Write("{0}   ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            int[,] matrix1 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = matrix[i, j+3];
                }
            }
            // Подсчет определителей.
            int[] determinant = new int[2];
            determinant[0]= matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[0, 0] * matrix[1, 2] * matrix[2, 1] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
            determinant[1]= matrix1[0, 0] * matrix1[1, 1] * matrix1[2, 2] + matrix1[0, 1] * matrix1[1, 2] * matrix1[2, 0] + matrix1[0, 2] * matrix1[1, 0] * matrix1[2, 1] - matrix1[0, 2] * matrix1[1, 1] * matrix1[2, 0] - matrix1[0, 0] * matrix1[1, 2] * matrix1[2, 1] - matrix1[0, 1] * matrix1[1, 0] * matrix1[2, 2];
            Console.Write("Determinant_1 = {0}\r\nDeterminant_2 = {1}", determinant[0], determinant[1]);
        }
    }
    
    
}
