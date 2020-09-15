using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double old = 1, res = 0;
            for(int i =1; old- res !=0; i++)
            {
                old = res;
                res += 1/ ((double)i * (i + 1) * (i + 2));
            }
            Console.WriteLine(old);
            Console.WriteLine(res);
        }
    }
}
