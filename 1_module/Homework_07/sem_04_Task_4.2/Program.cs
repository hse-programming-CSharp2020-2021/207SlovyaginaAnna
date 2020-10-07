using System;

namespace sem_04_Task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rnd.Next();
                    Console.Write("{0}   ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Determinant = {0}", matrix[0, 0] * matrix[1, 1]*matrix[2,2]+ matrix[0, 1] * matrix[1, 2] * matrix[2, 0]+ matrix[0, 2] * matrix[1, 0] * matrix[2, 1] - matrix[0, 2] * matrix[1, 1]*matrix[2,0]- matrix[0, 0] * matrix[1, 2] * matrix[2, 1]- matrix[0, 1] * matrix[1, 0] * matrix[2, 2]);
        }
    }
}
