﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Task02_xml
{
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
        public Professor()
        {

        }
        public Professor(string name) : base(name) { }
    }

    [Serializable]
    public class Dept
    {
        public string DeptName { get; set; }
        List<Human> staff;
        public List<Human> Staff { get { return staff; } set { staff = value; } }
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
        public University() { }
        public string UniversityName { get; set; }
        public List<Dept> Departments { get; set; }
    }


    class Program
    {
        static async void Main(string[] args)
        {
            University HSE = new University();
            HSE.UniversityName = "NRU HSE";

            Human[] deptStaff = { new Professor("Ivanov"),
                      new Professor("Petrov")
                    };

            Dept SE = new Dept("SE", deptStaff);
            HSE.Departments = new List<Dept>();
            HSE.Departments.Add(SE);

            University MSU = new University();
            MSU.UniversityName = "MSU";

            Human[] deptStaffM = { new Professor("Ivanov"),  new Professor("Chizov"),
                      new Professor("Petrov")
                    };

            Dept SEM = new Dept("SEM", deptStaffM);
            MSU.Departments = new List<Dept>();
            MSU.Departments.Add(SEM);

            University[] universities = new University[] { HSE, MSU };

            // Сериализация
            using (Stream file = new FileStream("JsonSer.json", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await JsonSerializer.SerializeAsync(file, universities);
            }



            // Десериализация
            University[] deserial;
            using (Stream file = File.OpenRead("JsonSer.json"))
            {
                deserial = await JsonSerializer.DeserializeAsync<University[]>(file);
                Array.ForEach(deserial, Console.WriteLine);



            }

            foreach (Dept d in deserial[0].Departments)
                foreach (Human h in d.Staff)
                {
                    if (h is Professor)
                        Console.WriteLine(d.DeptName + " prof.: " + h.Name);
                }

            foreach (Dept d in deserial[1].Departments)
                foreach (Human h in d.Staff)
                {
                    if (h is Professor)
                        Console.WriteLine(d.DeptName + " prof.: " + h.Name);
                }

            Console.ReadKey();
        }
    }
}
