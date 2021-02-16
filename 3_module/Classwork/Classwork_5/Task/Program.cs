using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp1;
            int inp2;
            inp1 = inp2 = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>(); ;
            while (inp1 > 0)
            {
                st.Push(inp1 % 10);
                inp1 /= 10;
            }
            LinkedList<int> list = new LinkedList<int>();
            while (inp2 > 0)
            {
                list.AddFirst(inp2 % 10);
                inp2 /= 10;
            }
            foreach (var item in st)
            { 
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
