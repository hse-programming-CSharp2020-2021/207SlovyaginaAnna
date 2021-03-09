using System;
using System.IO;
using System.Collections.Generic;

class ColorPoint
{
    public static string[] colors = { "Red", "Green", "DarkRed", "Magenta", "DarkSeaGreen", "Lime", "Purple", "DarkGreen", "DarkOrange", "Black", "BlueViolet", "Crimson", "Gray", "Brown", "CadetBlue" };
    public double x, y;
    public string color;
    public override string ToString()
    {
        string format = "{0:F3}    {1:F3}    {2}";
        return string.Format(format, x, y, color);
    }
}

class Test
{
    static Random gen = new Random();
    public static void Main()
    {
        string path = @"..\..\..\..\MyTest.txt";
        int N = 10; // Количество создаваемых объектов (число строк в файле)
                    //  TODO: Определить значение N 
        List<ColorPoint> list = new List<ColorPoint>();
        ColorPoint one;
        for (int i = 0; i < N; i++)
        {
            one = new ColorPoint();
            one.x = gen.NextDouble();
            one.y = gen.NextDouble();
            int j = gen.Next(0, ColorPoint.colors.Length);
            one.color = ColorPoint.colors[j];
            list.Add(one);
        }
        string[] arrData = Array.ConvertAll(list.ToArray(),
                     (ColorPoint cp) => cp.ToString());
        // Запись массива стpок в текстовый файл:         
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            ;
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                foreach (ColorPoint cp in list)
                {
                    bw.Write(cp.color);
                    bw.Write(cp.x);
                    bw.Write(cp.y);
                }
            }
        }
        Console.WriteLine("Записаны {0} строк в текстовый файл: \n{1}",
                                                                  N, path);
    }
} // class Test

