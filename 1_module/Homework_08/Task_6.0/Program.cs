using System;
using System.Globalization;

namespace Task_6._0
{
    class Program
    {
        static void Method(string input)
        {
            // Разбиваем строку на элементы
            string[] str = input.Split(new char[] {';'});
            // Создаем массив для целых чисел
            int[] arr = new int[str.Length];
            int k = 0;
            int med = 0;
            for(int i =0; i<str.Length; i++)
            {
                // Проверяем ли является ли элимент целым числом
                if(int.TryParse(str[i], out arr[k]))
                {
                    med += arr[k];
                    k++;
                }
            }
            Array.Resize(ref arr, k);
            // Выводим массив целых чисел
            foreach(int j in arr)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Среднее значение элементов массива: "+(double)( med / k));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку элементов разделенных точкой с запятой:");
            // Вводим сроку элементов
            string input = Console.ReadLine();
            Method(input);
        }
    }
}
