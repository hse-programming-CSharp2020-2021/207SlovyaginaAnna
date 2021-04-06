using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_2
{
    /*В программе описать классы:

 •Human;
 •Professor(наследник Human);
 •Department(композиционно включает список сотрудников – объекты типа Human);
 •University(агрегационно включает список департаментов) */
    [Serializable]

    public class Human
    {
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }
    }
    [Serializable]

    public class Dept
    {
        public string DeptName { get; set; }
        List<Human> staff;
        public List<Human> Staff { get { return staff; } }
        public Dept() { }
        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }
    [Serializable]
    public class University
    {
        public string UniversityName { get; set; }
        public List<Dept> Departments { get; set; }
    }
    class Program
    {
        static string GetString()
        {
            Random rnd = new Random();
            int n = rnd.Next(3, 9);
            string name = string.Empty;
            for (int i = 0; i < n; i++)
            {
                name += (char)(rnd.Next('a', 'z'));
            }
            return name;
        }
        static void Main(string[] args)
        {
            Professor[] professors1 = { new Professor(GetString()), new Professor(GetString()), new Professor(GetString()), new Professor(GetString()) };
            Professor[] professors2 = { new Professor(GetString()), new Professor(GetString()), new Professor(GetString()), new Professor(GetString()) };

            Dept[] depts = { new Dept("Department1", professors1), new Dept("Department2", professors2) };

            University university = new University()
            {
                UniversityName = GetString(),
                Departments = new List<Dept>(depts)
            };

            XmlSerializer formatter = new XmlSerializer(typeof(University),
                new Type[] { typeof(Dept), typeof(Professor), typeof(Human), });

            using (var stream = new FileStream("serialize.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, university);
            }

            using (var stream = new FileStream("serialize.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                University universityFromFile = formatter.Deserialize(stream) as University;
            }
        }
    }
}

