using System;
using System.Collections.Generic;
using System.IO;
namespace Task02
{
    class Program
    {
        static public void PrintFromFile()
        {
            using (FileStream f = new FileStream("../../../numbers.dat", FileMode.Open))
            using (BinaryReader fIn = new BinaryReader(f))
            {

                long n = f.Length / 4; int a;
                for (int i = 0; i < n; i++)
                {
                    a = fIn.ReadInt32();
                    Console.Write(a + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            using (BinaryWriter fOut = new BinaryWriter(new FileStream("../../../numbers.dat", FileMode.Create)))
            {
                Random r = new Random();
                for (int i = 0; i <= 10; i++)
                    fOut.Write(r.Next(1, 101));
            }
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);

            List<int> numbers = new List<int>();

            using (FileStream f = new FileStream("../../../numbers.dat", FileMode.Open))
            using (BinaryReader fIn = new BinaryReader(f))
            {
                long n = f.Length / 4; int a;
                for (int i = 0; i < n; i++)
                {
                    numbers.Add(fIn.ReadInt32());
                }
            }
            PrintFromFile();
            bool flag = false;
            for (int i = 0; i < 100 - num; i++)
            {
                if (numbers.Contains(num + i) && !flag)
                {
                    numbers[numbers.IndexOf(num + i)] = num;
                    flag = true;
                }
            }
            using (BinaryWriter fOut = new BinaryWriter(new FileStream("../../../numbers.dat", FileMode.Create)))
            {
                for (int i = 0; i < numbers.Count; i++)
                    fOut.Write(numbers[i]);
            }
            Console.WriteLine();
            PrintFromFile();
        }
    }
}
