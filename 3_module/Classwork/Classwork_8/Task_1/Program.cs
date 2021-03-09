using System;

namespace Task_1
{
    interface Ifigure
    {
        public double Area { get; }
    }
    class Circle : Ifigure
    {
        public double Area => 2 * Math.PI * Math.Pow(r, 2);
        double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override string ToString()
        {
            return $"Circle's radius: {r}, area: {Area}";
        }
    }
    class Square : Ifigure
    {
        public double Area => Math.Pow(len, 2);
        double len;

        public Square(double len)
        {
            this.len = len;
        }

        public override string ToString()
        {
            return $"Square's side: {len}, area: {Area}";
        }
    }
    class Program
    {
        static void Method<T>(T[] figures, double front) where T : Ifigure
        {
            foreach (T figure in figures)
            {
                if (figure.Area > front)
                {
                    Console.WriteLine(figure);
                }
            }
        }
        static void Main(string[] args)
        {
            int front = 0;
            int.TryParse(Console.ReadLine(), out front);
            Random random = new Random();
            Ifigure[] figures = new Ifigure[6];
            for (int i = 0; i < 3; i++)
            {
                figures[i] = new Square(random.Next(101)); 
            }
            for (int i = 3; i < figures.Length; i++)
            {
                figures[i] = new Circle(random.Next(101));
            }
             
            Method(figures, front);
        }
    }
}

