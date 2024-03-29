﻿using System;


public class Polygon
{ // Класс многоугольников
    int numb;       // Число сторон
    double radius;  // Радиус вписанной окружности
    public Polygon(int n = 3, double r = 1)
    { // конструктор       
        numb = n;
        radius = r;
    }
    public double Perimeter
    { // Периметр многоугольника - свойство
        get
        {   // аксессор свойства
            double term = Math.Tan(Math.PI / numb);
            return 2 * numb * radius * term;
        }
    }

    public double Area
    { // Площадь многоугольника - свойство
        get
        {   // аксессор свойства
            return Perimeter * radius / 2;
        }
    }
    public string PolygonData()
    {
        string res =
        string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
        numb, radius, Perimeter, Area);
        return res;
    }
}   // Polygon 
public class Program
{
    public static void Main()
    {
        Polygon polygon = new Polygon();
        Console.WriteLine("По умолчанию создан многоугольник: ");
        Console.WriteLine(polygon.PolygonData());
        double rad;
        int number;
        do
        {
            do Console.Write("Введите число сторон: ");
            while (!int.TryParse(Console.ReadLine(), out number) | number < 3);
            do Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
            polygon = new Polygon(number, rad);
            Console.WriteLine("Сведения о многоугольнике:");
            Console.WriteLine(polygon.PolygonData());
            Console.WriteLine("Для выхода нажмите клавишу ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        Console.WriteLine("Введите количество элементов массива:");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Polygon[] polygonArr=new Polygon[n];
            for(int i=0; i<n; i++)
            {
                do
                {
                    do Console.Write("Введите число сторон: ");
                    while (!int.TryParse(Console.ReadLine(), out number) | number < 3);
                    do Console.Write("Введите радиус: ");
                    while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
                    polygonArr[i] = new Polygon(number, rad);
                    Console.WriteLine("Сведения о многоугольнике:");
                    Console.WriteLine(polygonArr[i].PolygonData());
                    Console.WriteLine("Для выхода нажмите клавишу ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }
        else
            Console.WriteLine("Некорректный ввод");
        Polygon[] polygonArr1 = new Polygon[1];
        do
        {
            int k = 0;
            do Console.Write("Введите число сторон: ");
            while (!int.TryParse(Console.ReadLine(), out number) | number < 3);
            do Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
            polygonArr1[k] = new Polygon(number, rad);
            Console.WriteLine("Сведения о многоугольнике:");
            Console.WriteLine(polygonArr1[k++].PolygonData());
            Array.Resize(ref polygonArr1, polygonArr1.Length + 1);

        } while (number != 0 && rad != 0);
    }
}
