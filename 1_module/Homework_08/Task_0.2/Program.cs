using System;
using System.IO;

namespace Task_0._2
{
    class Program
    {
        static void Method(string path)
        {
            // Считываем строку из файла
            string[] str = File.ReadAllText(path).Split();
            int[] arr = new int[str.Length];
            // Массив степеней двойки
            int[] po = new int[arr.Length];
            int h = 1;
            string createText = string.Empty;
            for(int i =0; i<arr.Length; i++)
            {
                h = 1;
                arr[i] = int.Parse(str[i]);
                // Заполнение массива степеней двойки
                while (h < arr[i])
                {
                    h *= 2;
                }
                po[i] = (int)(h / 2);
                Console.WriteLine("arr[{0}]={1}\r\npo[{0}]={2}", i, arr[i], po[i]);
                createText += po[i]+" ";
            }
            File.WriteAllText("output.txt", createText);
        }
        static void Main(string[] args)
        {
            string path = "input.txt";
            Method(path);
        }
    }
}
