using System;

namespace Task_1
{
    class A
    {
        public void GetA()
        {
            Console.WriteLine("A");
        }
        public virtual void GetAA()
        {
            Console.WriteLine("AA");
        }
    }
    class B : A
    {
        public void GetA()
        {
            Console.WriteLine("B");
        }
        public override void GetAA()
        {
            Console.WriteLine("BB");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A[] arr = new A[10];
            Random ran = new Random();
            for(int k=0; k<arr.Length; k++)
            {
                if (ran.Next(0, 3) % 2 == 0) arr[k] = new A();
                else arr[k] = new B();
            }
            foreach (A d in arr) d.GetA();
            Console.WriteLine("\nB objects: ");
            foreach (A d in arr)
                if (d is B) d.GetA();
            Console.WriteLine("\nA objects: ");
            foreach (A d in arr)
                if (d is A) d.GetA();
            Console.WriteLine();
            Console.WriteLine();
            foreach (A d in arr) d.GetAA();
            Console.WriteLine("\nB objects: ");
            foreach (A d in arr)
                if (d is B) d.GetAA();
            Console.WriteLine("\nA objects: ");
            foreach (A d in arr)
                if (d is A) d.GetAA();
        }
    }
}
