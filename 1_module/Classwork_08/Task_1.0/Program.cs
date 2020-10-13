using System;
using System.IO;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int b = 0;
            while (Math.Pow(2, k) <=n)
            {
                k++;
            }
            for(int i = k-1; i>=0; i--)
            {
                if (Math.Pow(2, i) <= n)
                {
                    b += 1;

                    if (i != 0)
                    {
                        b *= 10;
                    }
                    n -=(int) Math.Pow(2, i);
                }
                else
                {
                    if(i!=0) 
                    {
                        b *= 10;
                    }
                }
            }
            Console.WriteLine(b);
            File.WriteAllText("1.txt", b.ToString() );
            string str = File.ReadAllText("1.txt");
            if(int.TryParse(str, out int m))
            {
                double answer = 0;
                int j = 0;
                while (m > 0)
                {
                    answer += Math.Pow(2, j) * (m % 10);
                    j++;
                    m /= 10;
                }
                Console.WriteLine(answer);
            }
        }
    }
}
