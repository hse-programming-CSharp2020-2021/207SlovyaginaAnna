using System;

namespace Task_8
{
    class Point
    {
        int X;
        int Y;
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int x
        {
            get { return X; }
        }
        public int y
        {
            get { return Y; }
        }
    }
        
    class Triangle
    {
        Point a;
        Point b;
        Point c;
        double AB;
        double BC;
        double CA;
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Point a = new Point(x1, y1);
            Point b= new Point(x2, y2);
            Point c= new Point(x3, y3);
            AB = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
            BC= Math.Sqrt(Math.Pow(c.x - b.x, 2) + Math.Pow(c.y - b.y, 2));
            CA = Math.Sqrt(Math.Pow(c.x - a.x, 2) + Math.Pow(c.y - a.y, 2));
        }
        public double ab { get { return AB; } }
        public double bc { get { return BC; } }
        public double ca { get { return CA; } }
        public double P
        {
            get { return AB + BC + CA; }
        }
        public double S
        {
            get 
            { 
            double p = P / 2;
                return Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
            }
        }
        public override string ToString()
        {
            return "AB = " + AB.ToString() + " BC = " + BC.ToString() + " CA = " + CA.ToString() + " P = " + P.ToString() + " S = " + S.ToString();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                int n = rnd.Next(5, 16);
                Triangle[] arr = new Triangle[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    while (true)
                    {
                        arr[i] = new Triangle(rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11));
                        if (arr[i].ab + arr[i].bc > arr[i].ca && arr[i].ab + arr[i].ca > arr[i].bc && arr[i].ab < arr[i].bc + arr[i].ca)
                            break;
                    }
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i].S < arr[j].S)
                        {
                            Triangle temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                foreach (Triangle i in arr)
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
