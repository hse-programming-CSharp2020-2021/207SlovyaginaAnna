using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                int max =-2147483648;
                int[] massive = new int[n];
                Console.WriteLine("Fill the array:");
                for(int i = 0; i < n; i++)
                {
                    massive[i] = int.Parse(Console.ReadLine());
                    if (massive[i] > max)
                    {
                        max = massive[i];
                    }
                }
                Console.WriteLine("Write parameter:");
                string inp = Console.ReadLine();
                if(int.TryParse(inp, out int p))
                {
                    for(int i = 0; i<n; i++)
                    {
                        if (massive[i] == max)
                        {
                            massive[i] = p;
                        }
                        Console.Write("" + massive[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
