using System;

namespace Task_4
{
    class Program
    {
        struct Rectangle : IComparable
        {
            int a;
            int b;
            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public int Area => a * b;
            public int CompareTo(object obj)
            {
                if (obj is Rectangle)
                {
                    Rectangle other = (Rectangle)obj;
                    return Area.CompareTo(other.Area);
                }
                return 1;
            }
        }

        class Block3D : IComparable
        {
            public Rectangle Rectangle { get; }

            public Block3D(Rectangle rectangle)
            {
                Rectangle = rectangle;
            }
            public int CompareTo(object obj)
            {
                if (obj is Block3D)
                {
                    Block3D other = (Block3D)obj;
                    return Rectangle.CompareTo(other.Rectangle);
                }
                return 1;
            }
            public override string ToString() => $"Block area = {Rectangle.Area}";
        }
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(13, 13);
            Rectangle rect2 = new Rectangle(135, 130);
            Block3D block1 = new Block3D(rect1);
            Block3D block2 = new Block3D(rect2);
            Console.WriteLine(block2.CompareTo(block1));
        }
    }
}
