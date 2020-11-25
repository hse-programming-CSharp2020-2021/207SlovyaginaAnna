using System;

namespace Task_2
{

    class Point
    {
        int x;
        int y;
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Display() { Console.WriteLine($"\r\nx = {X}\r\ny = {Y}"); }
        public double Area { get; set; }
    }
    class Circle : Point
    {
        int rad;
        public Circle(int x, int y, int Radi)
        {
            X = x;
            Y = y;
            rad = Radi;
        }
        public int Rad { get { return rad; } set { rad = value; } }
        public virtual double Area
        {
            get { return Math.PI * rad * rad; }
        }
        public double Len
        {
            get { return 2 * Math.PI * rad; }
        }
        public override void Display() { Console.WriteLine($"\r\nx = {X}\r\ny = {Y}\r\nArea = {Area}\r\nLen = {Len}"); }
    }
    class Square : Point
    {
        int side;
        public Square(int x, int y, int sid)
        {
            X = x;
            Y = y;
            side = sid;
        }
        public int Side { get { return side; } set { side = value; } }
        public virtual double Area
        {
            get { return side * side; }
        }
        public double Perimeter
        {
            get { return side * 4; }
        }
        public override void Display() { Console.WriteLine($"\r\nx = {X}\r\ny = {Y}\r\nArea = {Area}\r\nPerimeter = {Perimeter}"); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Display();
            Console.WriteLine(p.Area);
            p = new Circle(1, 2, 6);
            p.Display();
            Console.WriteLine(p.Area);
            p = new Square(3, 5, 8);
            p.Display();
            Console.WriteLine(p.Area);
        }
    }
}
