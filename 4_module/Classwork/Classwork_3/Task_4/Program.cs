using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_4
{
    class RandomCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new RandomEnumerator(n); 
        }
        private int n;
        public RandomCollection(int n)
        {
            this.n = n;
        }
    }
    class RandomEnumerator : IEnumerator
    {
        private int n;
        private int counter = -1;
        private readonly Random random = new Random();
        public object Current => random.Next();

        public bool MoveNext()
        {
            return ++counter < n;
        }

        public void Reset()
        {
            counter = -1;
        }
        public RandomEnumerator(int n)
        {
            this.n = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RandomCollection collection = new RandomCollection(5);
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
