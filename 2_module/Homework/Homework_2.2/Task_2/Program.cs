using System;
class Program
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания
                                        // СВОЙСТВО RO
                                        // СВОЙСТВО FI
        public string PointData
        {   // СВОЙСТВО 
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
        public double Ro
        {
            get
            {
                //#TODO1: реализовать свойство 
                return Math.Sqrt(Math.Pow(X,2)+Math.Pow(Y,2));
            }
        }
        public double Fi
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0)
                    return Math.Atan(Y / X);
                if (X == 0&&Y>0)
                    return Math.PI / 2;
                if (X == 0 && Y < 0)
                    return 3 * Math.PI / 2;
                if (X == 0 && Y == 0)
                    return 0;
                return 0;
            }
        }


        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                // #TODO3: следующий слайд
                double ra = Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2)),
                    rb = Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2)),
                    rc = Math.Sqrt(Math.Pow(c.X, 2) + Math.Pow(c.Y, 2));
                double[] r = new double[3] {ra,rb,rc };
                Array.Sort(r);
                for(int i=0; i<3; i++)
                {
                    if (r[i] == ra)
                        Console.WriteLine($"Ro a = {a.Ro:f2}, Fi a={a.Fi:f2}");
                    else if(r[i] == rb)
                    {
                        Console.WriteLine($"Ro b = {b.Ro:f2}, Fi b={b.Fi:f2}");
                    }
                    else
                        Console.WriteLine($"Ro c = {c.Ro:f2}, Fi c={c.Fi:f2}");
                }

            } while (x != 0 | y != 0);


        }
    }
}

