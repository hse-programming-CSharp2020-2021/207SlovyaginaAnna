using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    class Program
    {
        static string DeleteSpaces(string s)
        {
            StringBuilder t = new StringBuilder();
            t.AppendJoin(' ', s.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            return t.ToString();

        }
        static int MoreThanFour(string s)
        {
            int count = 0;
            string[] str= s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > 4) count++;
            }
            return count;
        }
        static int Vowels(string s)
        {

            List<string> glasn = new List<string>() { "а", "о", "и", "е", "ё", "э", "ы", "у", "ю", "я" };
            int n = 0;
            foreach (string word in s.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                n += Convert.ToInt32(glasn.Contains(word[0].ToString().ToLower()));
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DeleteSpaces(Console.ReadLine()));
            Console.WriteLine(MoreThanFour(Console.ReadLine()));
            Console.WriteLine(Vowels(Console.ReadLine()));
        }
    }
}
