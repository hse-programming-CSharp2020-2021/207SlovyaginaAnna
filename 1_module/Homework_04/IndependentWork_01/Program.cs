using System;

namespace IndependentWork_01
{
    class Program
    {
        // Метод ищущий числа удовлетворяющие условию a*a+b*b=c*c.
        static void Method()
        {
            for(int i = 1; i<20; i++)
            {
                for(int j=i+1; j <= 20; j++)
                {
                    if ((i * i + j * j )<= 20)
                    {
                        Console.WriteLine("a={0}, b={1}, c={2:F3}", i, j, Math.Sqrt(i*i+j*j));
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Method();
        }
    }
}
