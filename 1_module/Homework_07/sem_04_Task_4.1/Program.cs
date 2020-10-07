using System;

namespace sem_04_Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];
            Random rnd = new Random();
            for(int i=0; i < 2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    matrix[i, j] = rnd.Next();
                    Console.Write("{0}   ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Determinant = {0}", matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);
        }
    }
}
