using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    [Serializable]
    public class Student
    {
        string surname;
        int courseNum;
        public string Surname { get { return surname; }set { surname = value; } }
        public int CourseNum { get { return courseNum; } set { courseNum = value; } }
    }
    [Serializable]
    class Group
    {
        public string GroupNumber { get; private set; }
        public List<Student> students;
        public Group(string groupNumber, Student[] students)
        {
            this.students = new List<Student>(students);
            GroupNumber = groupNumber;
        }
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
            Random rnd = new Random();
            int n = rnd.Next(1, 6);
            Student[] students = new Student[n];
            for (int i=0; i<n; i++)
            {
                students[i] = new Student();
                students[i].CourseNum = rnd.Next(1, 5);
                students[i].Surname = GetString();
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            { formatter.Serialize(stream, students); }

            BinaryFormatter formatter1 = new BinaryFormatter();
            Student[] students1;
            using (Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                students1 = (Student[])formatter1.Deserialize(stream);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((students1[i].Surname+" "+ students1[i].CourseNum));
            }
        }
    }
}
