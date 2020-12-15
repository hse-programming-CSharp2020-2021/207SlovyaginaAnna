using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Ab
    {
        string abbriv;
        public Ab(string s)
        {
            string[] str = ValidatedSplit(s, ';');
            for (int i = 0; i < str.Length; i++)
            {
                if (!Validate(str[i])) throw new ArgumentException("Строка должна состоять только из символов латинского алфавита");
            }
            abbriv = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                abbriv += Abbrevation(str[i]) + "\n";

            }
        }
        public string Abb{get{ return abbriv; } }
        // проверка, что строки состоят только из символов латинского алфавита
        // и пробелом
        public  bool Validate(string str)
        {
            char[] english = new char[53];
            english[0] = ' ';
            for (int i = 1; i < 27; i++)
            {
                english[i] = (char)('a' + i);
            }
            for(int i = 1; i < english.Length; i++)
            {
                english[i] = (char)('A' + i);
            }
            if (str.IndexOfAny(english) < 0) return false;
            return true;
        } // end of Validate(string)
          // получение массива строк
          // каждый элемент проверен на соответствие формату
        public string[] ValidatedSplit(string str, char ch)
        {
            string[] output = null;
            output = str.Split(ch);
            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }
            return output;
        } // end of ValidatdSplit(string, char)
        // Обрезка строки по первому гласному
        public string Shorten(string str)
        {
            // TODO: учесть заглавные гласные
            char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            int ind = str.IndexOfAny(alph);
            return str.Substring(0, ind + 1);
        } // end of Shorten(string)
          // Метод создания аббревиатуры для ПОДстроки (в ней много слов)
        public string Abbrevation(string str)
        {
            string output = String.Empty;
            if (str != String.Empty)
            {
                string[] tmp = str.Split(' ');
                foreach (string s in tmp)
                {
                    string shortenS = Shorten(s);
                    FirstUpcase(ref shortenS);
                    output += shortenS;

                }
            }
            return output;
        } // end of Abbrevation(string)
          // Метод преобразования первого символа к заглавному
        public static void FirstUpcase(ref string str)
        {
            char[] chars = str.ToCharArray();
            str = str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        } // end of FirstUpcase(ref string)

    }
}
