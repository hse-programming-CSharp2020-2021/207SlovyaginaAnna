using System;
using System.IO;

namespace Task_0._1
{
    class Program
    {
        static void Method(string path)
        {
            // Считываем строку из файла
            string[] arr = File.ReadAllText(path).Split();
            // Создаем массив состояший из булевых переменных
            bool[] num = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // Проверяем элемент строки
                if (int.Parse(arr[i]) >= 0)
                {
                    num[i] = true;
                }
                else
                {
                    num[i] = false;
                }
            }
            // Выводим массив булевых переменных
            foreach (bool m in num)
            {
                Console.Write(m + " ");
            }
            string CreateStr = string.Empty;
            // Создаем строку из массива булевых элементов
            for (int i = 0; i < num.Length; i++)
            {
                CreateStr += num[i];
                CreateStr += " ";
            }
            foreach (string m in arr)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
            // Создаем файл и записываем ответ
            File.WriteAllText("output.txt", CreateStr);
        }
        static void Main(string[] args)
        {
            string path = "input.txt";
            Method(path);
        }
    }
}
