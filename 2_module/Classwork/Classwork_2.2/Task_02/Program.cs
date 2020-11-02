using System;

namespace Task_02
{
    class LatinChar
    {
        char _char;
        public char lc
        {
            get
            {
                return _char;
            }
        }
        public LatinChar()
        {
            _char = 'a';
        }
        public LatinChar(char latinCh)
        {
            _char = latinCh;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char min = char.Parse(Console.ReadLine());
            char max = char.Parse(Console.ReadLine());
            LatinChar ch = new LatinChar();
            for(char i=min; i<=max; i++)
            {
                ch = new LatinChar(i);
                Console.WriteLine(ch.lc);
            }
        }
    }
}
