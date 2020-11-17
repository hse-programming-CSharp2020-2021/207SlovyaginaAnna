using System;

namespace Task_9
{
    class LinearEquation
    {
        int a;
        int b;
        int c;
        public LinearEquation(int x, int y, int z)
        {
            a = x; b = y; c = z;
        }
        public double Root()
        {
            return (c - b) / a;
        }
        public override string ToString()
        {
            return a.ToString()+"x +"+b.ToString()+" = "+c.ToString()+"\r\nx = " + Root().ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                Console.WriteLine("Enter n");
                int n = int.Parse(Console.ReadLine());
                LinearEquation[] arr = new LinearEquation[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new LinearEquation(rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11));
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i].Root() < arr[j].Root())
                        {
                            LinearEquation temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                foreach (LinearEquation i in arr)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Enter 0 to escape");
                string s = Console.ReadLine();
                if (s == "0")
                    break;
            }
        }
    }
}
