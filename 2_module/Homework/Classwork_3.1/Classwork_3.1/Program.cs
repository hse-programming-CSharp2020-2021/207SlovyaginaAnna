using System;

namespace Classwork_3._1
{
    class Program
    {
        delegate void WrArr(int[] arr);
        delegate int[] ConArr(int x);
        static int[] ArrayConvert(int n)
        {
            int[] arr = new int[0];
            while (n > 0)
            {
                int a = n % 10;
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = a;
                n /= 10;
            }
            return arr;
        }
        static void ArrayWrite(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            WrArr wrArr = ArrayWrite;
            ConArr conArr = ArrayConvert;
            wrArr(new int[] { 23, 45, 34, 78, 90 });
            Console.WriteLine();
            wrArr(conArr(67345));
        }
    }
}
