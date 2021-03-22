using System;
using Street;
using System.IO;

namespace EmeraldCityPart2
{
    class Program
    {
        static Streets[] Street()
        {
            Streets[] streets=new Streets[0];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int count = 0;
                    while (!sr.EndOfStream)
                    {
                        Array.Resize(ref streets, streets.Length + 1);
                        string line = sr.ReadLine();
                        string[] arr = line.ToString().Split(' ');
                        int[] array = new int[arr.Length - 1];
                        streets[count] = new Streets();
                        streets[count].Name = arr[0].ToString();
                        for (int j = 0; j < array.Length; j++)
                        {
                            array[j] = int.Parse(arr[j + 1]);
                        }
                        streets[count++].Houses = array;
                    }
                }
                return streets;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        static void MagicStreets(Streets[] streets)
        {
            Console.WriteLine("Magic streets");
            foreach(Streets st in streets)
            {
                if (st.Houses.Length % 2 == 1 && +st)
                    Console.WriteLine(st);
            }
        }
        static string path = @"C:\Users\Operator\207SlovyaginaAnna\3_module\Classwork\Classwork_10\EmeraldCity\bin\Debug\netcoreapp3.1\out.txt";
        static void Main(string[] args)
        {
            MagicStreets(Street());
        }
    }
}
