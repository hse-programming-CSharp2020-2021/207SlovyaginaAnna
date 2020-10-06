﻿using System;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] massive = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - j -1) { massive[i, j] = 0; }
                    else
                    {
                        if (i > n-j-1 ) { massive[i, j] = 1; }
                        else  { massive[i, j] = -1;  }
                    }
                    Console.Write("{0}  ", massive[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
