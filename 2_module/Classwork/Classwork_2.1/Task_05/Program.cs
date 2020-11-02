using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[i + 1];
                arr[i][0] = 1;

            }
            for(int i=0; i<n; i++)
            {
                arr[i][arr[i].Length - 1] = 1;
            }
            arr[1][1] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < arr[i].Length-1; j++)
                {
                    arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                }
            }

            foreach (int[] i in arr)
            {
                foreach (int m in i)
                {
                    Console.Write(m + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
