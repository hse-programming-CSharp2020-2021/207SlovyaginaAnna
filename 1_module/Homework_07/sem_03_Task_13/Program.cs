using System;

namespace sem_03_Task_13
{
    class Program
    {
        // Метод, создающий и заполняющий рандомными числами, массив.
        static void Method(int k, int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for(int i=0; i<a.Length; i++)
            {
                a[i] = rnd.Next(-100, 101);
                
            }
            for(int i = 0; i < a.Length; i+=k)
                // Вывод элементов номера которых кратны к.
            {
                Console.Write("{0} = {1}  ", i, a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write k:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Write n:");
            string inp2 = Console.ReadLine();
            if(int.TryParse(inp1, out int k)&&int.TryParse(inp2, out int n) && k > 0 && n >= k)
            {
                Method(k, n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
