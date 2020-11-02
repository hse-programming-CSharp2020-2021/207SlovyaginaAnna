using System;
using System.Data;

class Birthday
{
    string name; // закрытое поле - фамилия
    int year, month, day; // Закрытые поля: год, месяц, день рождения

    public Birthday()
    {
        year = 1970;
        month = 1;
        day = 1;
    }
    public Birthday(string name, int y, int m, int d)
    { // Конструктор
        this.name = name;
        year = y; month = m; day = d;
    }
    DateTime Date
    { // закрытое свойство - дата рождения
        get { return new DateTime(year, month, day); }
    }
    public string DataStr
    {
        get
        {
            DateTime d = new DateTime(day, month, year);
            d.AddDays(HowManyDays);
            return d.AddDays(HowManyDays).ToString();
        }
    }
    public string Information
    {   // свойство - сведения о человеке
        get
        {
            return name + ", дата рождения " + day + ":" + month + ":" + year;
        }
    }
    public int HowManyDays
    { // свойство - сколько дней до дня рождения
        get
        {
            // номер сего дня от начала года:
            int nowDOY = DateTime.Now.DayOfYear;
            //  номер дня рождения от начала года: 
            int myDOY = Date.DayOfYear;
            int period = myDOY >= nowDOY ? myDOY - nowDOY :
                                           365 - nowDOY + myDOY;
            return period;
        }

    }
    class Program
    {
        static void Main()
        {
            Birthday md = new Birthday("Чапаев", 1887, 2, 9);
            Console.WriteLine(md.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(md.HowManyDays);
            Console.WriteLine(md.DataStr);

            Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);
            Console.WriteLine(km.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(km.HowManyDays);
            Console.WriteLine(km.DataStr);
        }
    }
}