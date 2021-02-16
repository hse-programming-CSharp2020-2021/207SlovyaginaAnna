using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr= Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == '(' || arr[i] == '[' || arr[i] == '{')
                    stack.Push(arr[i]);
                if (arr[i] == ')' || arr[i] == ']' || arr[i] == '}')
                {
                    if (stack.Count==0)
                    {
                        Console.WriteLine("False");
                        Environment.Exit(0);
                    }
                    if (arr[i] == ')')
                    {
                        if (stack.Peek() != '(')
                        {
                            Console.WriteLine("False");
                            Environment.Exit(0);
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    
                    if (arr[i] == ']')
                    {
                        if (stack.Peek() != '[') { 
                        
                            Console.WriteLine("False");
                            Environment.Exit(0);
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                  
                    if (arr[i] == '}')
                    {
                        if (stack.Peek() != '{')
                        {
                            Console.WriteLine("False");
                            Environment.Exit(0);
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                   
                }
            }
            if (stack.Count==0)
                Console.WriteLine("True");


        }
    }
}
