using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] a = new char[3][][];
            for (int i = 0; i < 3; i++)
            {
                a[i] = new char[3 - i][];
            }
            a[0][0] = new char[] { 'a', 'b' };
            a[0][1] = new char[] { 'c', 'd', 'e' };
            a[0][2] = new char[] { 'f', 'g', 'h', 'l' };
            a[1][0] = new char[] { 'j', 'k' };
            a[1][1] = new char[] { 'l', 'm', 'n' };
            a[2][0] = new char[] { 'o', 'p', 'q', 'r' };
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)
                {

                    for (int k = 0; k < a[i][j].Length; ++k)
                    {
                        Console.Write(a[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
