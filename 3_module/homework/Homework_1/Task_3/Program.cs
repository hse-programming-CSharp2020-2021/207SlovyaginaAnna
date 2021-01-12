using System;

namespace Task_3
{
    delegate double delegateConvertTemperature(double n);
    class TemperatureConvertImp
    {
        public double fromFtoC(double f)
        {
            return 5 / 9 * (f - 32);
        }
        public double fromCtoF(double c)
        {
            return 9 / 5 * c + 32;
        }
    }
    public static class StaticTempConverts
    {
        public static double fromCtoK(double c)
        {
            return c + 273;
        }
        public static double fromKtoC(double k)
        {
            return k - 273;
        }
        public static double fromCtoRa(double c)
        {
            return (c + 273.15) * 9 / 5;
        }
        public static double fromRatoC(double ra)
        {
            return (ra - 491.67) * 5 / 9;
        }
        public static double fromCtoRe(double c)
        {
            return c * 4 / 5;
        }
        public static double fromRetoC(double re)
        {
            return re * 5 / 4;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            TemperatureConvertImp tci = new TemperatureConvertImp();
            delegateConvertTemperature[] fromC = new delegateConvertTemperature[] { tci.fromCtoF, StaticTempConverts.fromCtoK, StaticTempConverts.fromCtoRa, StaticTempConverts.fromCtoRe };
            delegateConvertTemperature[] toC=new delegateConvertTemperature[] { tci.fromFtoC, StaticTempConverts.fromKtoC, StaticTempConverts.fromRatoC, StaticTempConverts.fromRetoC };
            Console.WriteLine("Write any letter to escape the programm");
            while (true)
            {
                Console.WriteLine("Write temperature in C");
                if(!double.TryParse(Console.ReadLine(), out double n))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("F\tK\tRa\tRe\t");
                    for(int i=0; i<fromC.Length; i++)
                    {
                        Console.Write($"{fromC[i](n):f2}\t");
                    }
                    
                    Console.WriteLine();
                }
            }

        }
    }
}
