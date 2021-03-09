using System;

namespace Task_2
{
    interface ISequence
    {
        double GetElement(int n);
    }
    class ArithmeticalProgression : ISequence
    {
        double a1;
        double d;
        public ArithmeticalProgression(double a1, double d)
        {
            this.a1 = a1;
            this.d = d;
        }
        public double GetElement(int n)
        {
            return a1 + d * (n - 1);
        }
    }
    class GeometricProgression : ISequence
    {
        double b1;
        double q;
        public GeometricProgression(double b1, double q)
        {
            this.b1 = b1;
            this.q = q;
        }
        public double GetElement(int n)
        {
            return b1 + Math.Pow(q, n - 1);
        }
    }
    class Program
    {
        static double Sum(ISequence seq, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += seq.GetElement(i);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticalProgression(1, 2), 3));
        }
    }
}
