using System;

namespace Task_1
{
    class UserString
    {
        string str;
        static Random gen = new Random();
        public string S { get { return str; } }
        public UserString(int k, char minChar, char maxChar)
        {
            if (k < 0)
                throw new Exception("Аргумент метода должен быть положительным!");
            // minChar, minChar - границы диапазона символов
            if (maxChar < minChar)
            {
                char c = minChar;
                minChar = maxChar;
                maxChar = c;
            }
            // пустая строка, останется пустой, если символов 0
            string line = String.Empty;
            for (int i = 0; i < k; i++)
                line += (char)gen.Next(minChar, maxChar + 1);
            str = line;
        }
        public string MoveOff(string s1, string s2) 
        {
            string res = s1;
            int index;
            for (int i = 0; i < s2.Length; i++)
                while ((index = res.IndexOf(s2[i])) >= 0)
                    res = res.Remove(index, 1);
            return res;
        }
        class Program
        {
            // comment - строка-сообщение для получения данных
            public static int GetIntValue(string comment)
            {
                int intVal;
                do Console.Write(comment);
                while (!int.TryParse(Console.ReadLine(), out intVal));
                return intVal;
            }

            static void Main(string[] args)
            {
                int n=GetIntValue("Введите количество символов в строке");
                Console.WriteLine();
                UserString str = new UserString(n, '0', '9');
                Console.WriteLine($"Полученная строка - {str.S}");
                Console.WriteLine(str.MoveOff(str.S, "02468"));
            }
        }
    }
}
