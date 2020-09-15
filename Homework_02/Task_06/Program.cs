using System;


namespace Task_06
{
    class Program
    {
        static void Value()//Метод выводящий сумму, отведенную на покупку компьютерных игр
        {
            Console.WriteLine("Введите ваш бюджет:");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Введите процент, выделенный на компьютерные игры:");
            string inp2 = Console.ReadLine();
            if(double.TryParse(inp1, out double b) && int.TryParse(inp2, out int p))
            {
                Console.WriteLine("Бюджет выделенный на компьютерные игры - "+ (((double)p / 100) * b).ToString("C"));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Main(string[] args)
        {
            Value();
            while (true)
            {
                Console.WriteLine("Для повтора введите next для завершения stop ");
                string str = Console.ReadLine();
                if (str == "next")
                {
                    Value();
                }
                if (str == "stop")
                {
                    break;
                }
            }
        }
    }
}
