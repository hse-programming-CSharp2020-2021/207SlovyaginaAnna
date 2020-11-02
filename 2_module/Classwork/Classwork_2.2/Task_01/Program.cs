using System;
class Circle
{
    private double _r;

    public double R
    {
        get
        {
            return _r;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Negative value");
            _r = value;
        }
    }

    public double S
    {
        get
        {
            return Math.PI * _r * _r;
        }
    }
     public double L
    {
        get
        {
            return Math.PI * 2 * _r;
        }
    }

    public Circle()
    {
        R = 1;
    }

    public Circle(double radius)
    {
        R = radius;
    }

    public override string ToString()
    {
        return $"Circle: radius = {_r}, Length = {L}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        double rmin = double.Parse(Console.ReadLine());
        double rmax = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        Circle[] circle=new Circle[n];
        int max=0;
        for (int i = 0; i <n; i ++)
        {
            circle[i] = new Circle(rnd.NextDouble()* (rmax - rmin) + rmin);
            Console.WriteLine(circle[i].ToString());
            if (circle[i].S > circle[max].S)
            {
                max = i;
            }
        }
        Console.WriteLine($"Круг наибольшей площади: {circle[max].ToString()}");
    }
}


