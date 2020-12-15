using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        private static void BracketsCount(string tmp, ref int openBrackets, ref int closedBrackets)
        {
            for (int i = 0; i < tmp.Length; i++)
            {
                // статистика по строчным латинским символам
                if (tmp[i] >= 'a' && tmp[i] <= 'z')
                    stat[tmp[i] - 'a']++;
                if (tmp[i] == '{') openBrackets++;
                if (tmp[i] == '}') closedBrackets++;
            }
        }
        public static string StatToString()
        {
            string output = string.Empty;
            for (int i = 0; i < stat.Length; i++)
            {
                output += (char)('a' + i) + " - " + stat[i] + " ";
            }
            return output;
        }

        static int[] stat = new int[26]; // статистика по лат. буквам
        static void Main(string[] args)
        {
            string tmp;
            int openBrackets = 0; // количество {
            int closedBrackets = 0; // количество }
            int total = 0; // общее количество символов файла

            var In = Console.In; // Запоминаем стандартный входной поток
                                 // Создаем файл и текстовый входной поток: 
            StreamReader stream_in = new StreamReader(@"..\..\..\Program.cs");
            // Настраиваем стандартный входной поток на чтение из файла:
            Console.SetIn(stream_in);
            // чтение из файла
            // восстановление потока
            while (true)
            { // цикл бесконечен
                tmp = stream_in.ReadLine();
                if (tmp == null) break; // условие прерывание цикла
                total += tmp.Length;
                // подсчёт количества фигурных скобок
                BracketsCount(tmp, ref openBrackets, ref closedBrackets);
                Console.WriteLine(tmp.Trim());
                Console.WriteLine(tmp);
            }
            // восстанавливаем состояние потока
            stream_in.Close();
            Console.SetIn(In);
            // обрабатываем данные по скобкам
            tmp = "Баланс скобок не соблюдён";
            if (openBrackets == closedBrackets)
                tmp = "Баланс скобок соблюдён, количество блоков " + closedBrackets;
            Console.WriteLine(StatToString());
            Console.WriteLine(tmp);
            stream_in.Close();
            Console.SetIn(In);
            Console.WriteLine("Для завершения работы нажмите любую клавишу.");
            Console.ReadKey();

        }

    }
}
