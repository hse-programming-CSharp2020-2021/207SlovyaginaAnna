using System;
using System.Collections.Generic;

namespace A
{
    /// <summary>
    /// Пассажир
    /// </summary>
    public class Passenger
    {
        protected string name;
        protected string lastName;
        protected int age;
        public bool IsOld { private set; get; }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                if (value > 65)
                    IsOld = true;
                age = value;
            }
            get { return age; }
        }
        public override string ToString()
        {
            string str = $"Name - {name}; lastName - {lastName}; Age - {age}";
            return str;
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        int numberOfChildren;
        public bool IsNewBorn { private set; get; }
        public int NumberOfChildren
        {
            set
            {
                numberOfChildren = value;
            }
            get { return numberOfChildren; }
        }
        public int ageOfTheYoungest { set { if (value <5)
                    IsNewBorn = true;
                        } }
        public override string ToString()
        {
            string str = $"Name - {name}; lastName - {lastName}; Age - {age}; Number of children - {numberOfChildren}; Has new born - {IsNewBorn}";
            return str;
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }
        public void StartServingQueue()
        {
            if (priorityQueue.Count <= 3)
            {
                while(priorityQueue.Count>0)
                {
                    Console.WriteLine(priorityQueue.Peek());
                    priorityQueue.Dequeue();
                }
                while(ordinaryQueue.Count>0)
                {
                    Console.WriteLine(ordinaryQueue.Peek());
                    ordinaryQueue.Dequeue();
                }
            }
            else
            {
                while (priorityQueue.Count > 0 || ordinaryQueue.Count > 0)
                {
                    if (priorityQueue.Count > 0)
                    {
                        Console.WriteLine(priorityQueue.Peek());
                        priorityQueue.Dequeue();
                    }
                    if (ordinaryQueue.Count > 0)
                    {
                        Console.WriteLine(ordinaryQueue.Peek());
                        ordinaryQueue.Dequeue();
                    }
                }
            }
        }
    }

    class MainClass
    {
        public static void Main()
        {
            PassengerQueue pQ = new PassengerQueue();
            Random rnd = new Random();
            for(int i=0; i<7; i++)
            {
                int withChildren = rnd.Next(0, 2);
                if (withChildren == 1)
                {
                    PassengerWithChildren pc = new PassengerWithChildren();
                    int num = rnd.Next(3, 8);
                    string str = "";
                    for (int j = 0; j < num; j++)
                        str += (char)rnd.Next(97, 123);
                    pc.Name = str;
                    num= rnd.Next(3, 8);
                    str = "";
                    for (int j = 0; j < num; j++)
                        str += (char)rnd.Next(97, 123);
                    pc.LastName = str;
                    pc.Age = rnd.Next(30, 51);
                    pc.NumberOfChildren = rnd.Next(1, 5);
                    pc.ageOfTheYoungest = rnd.Next(1, 20);
                    pQ.AddToQueue(pc);
                    Console.WriteLine(pc);
                }
                else
                {
                    Passenger pc = new Passenger();
                    int num = rnd.Next(3, 8);
                    string str = "";
                    for (int j = 0; j < num; j++)
                        str += (char)rnd.Next(97, 123);
                    pc.Name = str;
                    num = rnd.Next(3, 8);
                    str = "";
                    for (int j = 0; j < num; j++)
                        str += (char)rnd.Next(97, 123);
                    pc.LastName = str;
                    pc.Age = rnd.Next(18, 86);
                    pQ.AddToQueue(pc);
                    Console.WriteLine(pc);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            pQ.StartServingQueue();
        }
    }
}