using System;
using Street;
using System.IO;
using System.Text;

namespace EmeraldCity
{
    class Program
    {
        static string inputPath = "data.txt";
        static string outputPath = "out.txt";
        static string RandomName()
        {
            Random rnd = new Random();
            int len = rnd.Next(3, 10);
            string name = "";
            for (int i = 0; i < len; i++)
            {
                name += rnd.Next('а', 'я');
            }
            return name;
        }
        static bool CorrectFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(inputPath))
                {
                    string line;
                    string[] arr;
                    int n;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        arr = line.ToString().Split(' ');
                        if (arr.Length > 1)
                        {
                            for (int i = 1; i < arr.Length; i++)
                            {
                                if (!int.TryParse(arr[i], out n) || n > 100 || n < 0)
                                    return false;
                            }
                        }
                        else
                            return false;
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static int[] CreateRandomArray()
        {
            Random rnd = new Random();
            int length = rnd.Next(1, 10);
            int[] arr = new int[length];
            for(int i=0; i<length; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }
            return arr;
        }
        static Streets[] CreateStreets(int n)
        {
            Streets[] streets = new Streets[n];
            for(int i=0; i<n; i++)
            {
                streets[i] = new Streets();
                streets[i].Name = RandomName();
                streets[i].Houses = CreateRandomArray();
            }
            return streets;
        }
        static Streets[] Street(int n)
        {
            Streets[] streets = new Streets[n];
            try
            {
                using (StreamReader sr = new StreamReader(inputPath))
                {
                    int count = 0;
                    while (!sr.EndOfStream && n > 0)
                    {
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
                        n--;
                    }
                    if (count < n)
                        Array.Resize(ref streets, count + 1);
                }
                return streets;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write n:");
            int n;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n)&& n>0)
                    break;
                else
                    Console.WriteLine("Incorrect input! Try again");
            }
            Streets[] streets;
            if (!CorrectFile())
            {
                Console.WriteLine("Warning! File is not in a correct format");
                streets = CreateStreets(n);
            }
            else
            {
                streets = Street(n);
            }
            Console.WriteLine("\tINFO");
            try
            {
                using (StreamWriter sw=new StreamWriter(outputPath))
                    foreach (Streets st in streets)
                    {
                        Console.WriteLine(st);
                        sw.WriteLine(st.ToString());
                    }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
