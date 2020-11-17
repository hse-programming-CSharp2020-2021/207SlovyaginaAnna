using System;

namespace Task_11
{
    class GeometricProgression
    {
        double _start;
        double _increment;
        public GeometricProgression()
        {
            _start = 0;
            _increment = 1;
        }
        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }
        public double this[int index]
        {
            get { return _start * Math.Pow(_increment, index - 1); }
        }
        public double GetSum(int n)
        {
            double sum = 0;
            for(int i=1; i <= n;i++)
            {
                sum += this[i];
            }
            return sum;
        }
        public override string ToString()
        {
            return $"start = {_start}; increment = {_increment}";
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
                GeometricProgression[] arr = new GeometricProgression[n];
                for(int i=0; i<arr.Length; i++)
                {
                    arr[i] = new GeometricProgression(rnd.Next(0, 11), rnd.Next(1, 6));
                    Console.WriteLine(arr[i]);
                }
                int step = rnd.Next(3, 16);
                Console.WriteLine($"step = {step}");
                for(int i=0; i < arr.Length; i++) { Console.WriteLine(arr[i].GetSum(step)); }
                Console.WriteLine("Enter 0 to escape");
                string s = Console.ReadLine();
                if (s == "0")
                    break;
            }
        }
    }
}
