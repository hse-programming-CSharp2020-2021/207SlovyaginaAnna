using System;

namespace Task_6
{
    class Program
    {
        static string line(char[] series)
        {
            string result = string.Empty;
            string[] arr = new string[] { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= 97 && series[i] <= 122) result += series[i];
                else
                {
                    result += arr[Math.Abs(48 - series[i])];
                }
            }
            return result;
        }
        static char[] series(int k, int ratio)
        {
            char[] arr = new char[k];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = '-';
            }
            Random rnd = new Random();
            for (int i = 0; i < k * ratio / 100; i++)
            {
                while (true)
                {
                    int index = rnd.Next(0, k);
                    if (arr[index] == '-') { arr[index] = (char)rnd.Next('a', (char)((int)'z' + 1)); break; }
                }
            }
            for (int i = 0; i < arr.Length - k * ratio / 100; i++)
            {
                while (true)
                {
                    int index = rnd.Next(0, k);
                    if (arr[index] == '-') { arr[index] = (char)rnd.Next(48, 58); break; }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) { Console.WriteLine("Неверный ввод"); return; }
            Console.WriteLine("Введите процент букв");
            if (!int.TryParse(Console.ReadLine(), out int p) || p <= 0 || p > 100) { Console.WriteLine("Неверный ввод"); return; }
            char[] arr = series(n, p);
            foreach (char i in arr) { Console.WriteLine(i); }
            Console.WriteLine();
            Console.WriteLine(line(arr));
        }
    }
}

