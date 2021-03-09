using System;

namespace Classwork_6
{
    interface ICalculation
    {
        double Perform(double x);
    }
    class Add : ICalculation
    {
        double m;
        public Add(double m)
        {
            this.m = m;
        }
        public double Perform(double x)
        {
            return x + m;
        }
    }
    class Multiply : ICalculation
    {
        double m;
        public Multiply(double m)
        {
            this.m = m;
        }
        public double Perform(double x)
        {
            return x * m;
        }
    }

    class Program
    {
        static double Calculate(double x, Add add, Multiply multyply)
        {
            x = add.Perform(x);
            x = multyply.Perform(x);
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(1, new Add(2), new Multiply(3)));
        }
    }
}
