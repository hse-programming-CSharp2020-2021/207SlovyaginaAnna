using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int[,] arr = new int[n, n];
                int k = 1;
                for(int i=0; i < n; i++)
                {
                    for(int j=0; j<n; j++)
                    {
                        arr[i, j] = j + k;
                        if (arr[i, j] > n)
                            arr[i, j] -= n;
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                    k++;
                }
            }
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
