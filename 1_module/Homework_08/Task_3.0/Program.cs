using System;
using System.IO; // Пространство имён System.IO -> File.
using System.Text; // Кодировка.

class Program
{
    static void WriteTextMethod(string fileName, int linesCount, Encoding enc)
    {
        int r = 0;
        string[] str = new string[linesCount];
        File.WriteAllText(fileName, string.Empty, enc); // Создаём пустой файл.
        Console.WriteLine("Переписка до форматирования:");
        for (int i = 0; i < linesCount; i++)
        {
            string message = string.Empty; // предложение
            int length = rand.Next(20, 51); // Длина сообщения от 20 до 50 символов (51 - 50 включён в диапазон)
            for (int j = 0; j < length; j++)
            {
                message += (char)rand.Next('А', 'Я'); // Посимвольное добавление букв в сообщение. "Ё" нет в диапазоне от А до Я!
            }
            r = rand.Next(0, 2);
            if (r == 1) { message += "."; }
            Console.WriteLine(message);
            str[i] = message;
        }
        File.WriteAllLines(fileName, str, enc);
    }
    static void ReadTextMethod(string fileName, Encoding enc)
    {
        // читаем сформированный файл и обрабатываем предложения
        string[] messages = File.ReadAllLines(fileName, enc); // Массив сообщений из переписки.
        Console.WriteLine(Environment.NewLine + "Переписка после форматирования:");
        
            for (int i =0; i<messages.Length; i++)
        {
            char[] arr = messages[i].ToCharArray();
           
            if ((int)arr[arr.Length - 1] == 46)
            {
                Array.Resize(ref arr, arr.Length - 1);
            }
            messages[i] = string.Empty;
            for(int l =0; l<arr.Length; l++)
            {
                messages[i] += arr[l];
            }
            Console.WriteLine(messages[i]);
        }
    }
    static Random rand = new Random();
    static void Main()
    {
        const string fileName = "dialog.txt";
        Encoding enc = Encoding.Unicode;
        const int linesCount = 6;  

        WriteTextMethod(fileName, linesCount, enc);
        ReadTextMethod(fileName, enc);
    }
}