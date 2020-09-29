using System;

namespace IndependentWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            int sign=0;
            string sum="";
            Console.WriteLine("If you want to finish this program, enter letter");
            // Условие завершения ввода.
            while (true)
            {
                string input = Console.ReadLine();
                sum += " "+input;
                // Строка для хранения введенных значений.
                if(!int.TryParse(input, out int m) || sign < -1000)
                {
                    break;
                }
                else
                {
                    if (m < 0)
                    {
                        sign += Math.Abs(m);
                        // Переменная для подсчета суммы отрицательных чисел.
                        n += 1;
                        // Переменная для подсчета количества отрицательных чисел.
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(sign/n);
        }
    }
}
