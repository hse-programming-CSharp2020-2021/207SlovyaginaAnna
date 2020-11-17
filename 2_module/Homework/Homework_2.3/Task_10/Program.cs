using System;

namespace Task_10
{
    class Circle
    {
        int x;
        int y;
        int r;
        public Circle(int a, int b, int c)
        {
            x = a;y = b; r = c;
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public int R
        {
            get { return r; }
        }
        public override string ToString()
        {
            return $"x = {x}; y = {y}; R = {r}";
        }

    }
    class Program
    {
        static bool Method(int x1, int y1, int r1, int x2, int y2, int r2)
        {
            if (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) < r1 + r2)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                Console.WriteLine("Enter n");
                int n = int.Parse(Console.ReadLine());
                Circle[] arr = new Circle[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Circle(rnd.Next(1, 16), rnd.Next(1, 16), rnd.Next(1, 16));
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
                Circle obj = new Circle(rnd.Next(1, 16), rnd.Next(1, 16), rnd.Next(1, 16));
                Console.WriteLine(obj);
                Console.WriteLine("С этой окружностью пересекаются окружности:");
                for(int i=0; i<arr.Length; i++)
                {
                    if (Method(obj.X, obj.Y, obj.R, arr[i].X, arr[i].Y, arr[i].R))
                        Console.WriteLine(arr[i]);
                }
                Console.WriteLine("Enter 0 to escape");
                string s = Console.ReadLine();
                if (s == "0")
                    break;
            }
        }
    }
}
