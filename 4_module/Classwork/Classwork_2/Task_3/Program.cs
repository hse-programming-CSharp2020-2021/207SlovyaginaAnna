using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization;

namespace Task_3
{
    [DataContract]
    [Serializable]
    struct ConsoleSymbolStruct
    {
        [DataMember]
        char simb;
        [DataMember]
        int x;
        [DataMember]
        int y;
        public char Simb { get { return simb; } }
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public ConsoleSymbolStruct(char s, int x, int y)
        {
            simb = s;
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{simb} {x} {y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ConsoleSymbolStruct[] symb = new ConsoleSymbolStruct[rnd.Next(3, 10)];
            for(int i=0; i < symb.Length; i++)
            {
                symb[i] = new ConsoleSymbolStruct((char)(rnd.Next('a', 'z')), rnd.Next(1, 100), rnd.Next(1, 100));
                Console.WriteLine(symb[i]);
            }
            ConsoleSymbolStruct[] symb2;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Binaryser.bin", FileMode.Create))
            {
                bf.Serialize(fs, symb);
            }
            using (FileStream fs = new FileStream("Binaryser.bin", FileMode.Open))
            {
                symb2 = (ConsoleSymbolStruct[])bf.Deserialize(fs);
            }
            Array.ForEach(symb2, x => Console.WriteLine(x));
            Console.WriteLine();

            XmlSerializer xs = new XmlSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream fs = new FileStream("Xmlser.xml", FileMode.Create))
            {

                bf.Serialize(fs, symb);
            }
            using (FileStream fs = new FileStream("Xmlser.xml", FileMode.Open))
            {
                symb2 = (ConsoleSymbolStruct[])bf.Deserialize(fs);
            }
            Array.ForEach(symb2, x => Console.WriteLine(x));
            Console.WriteLine();

            string data = JsonSerializer.Serialize<ConsoleSymbolStruct[]>(symb);
            symb2 = JsonSerializer.Deserialize<ConsoleSymbolStruct[]>(data);
            Array.ForEach(symb2, x => Console.WriteLine(x));
            Console.WriteLine();

            var serializer = new DataContractSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream fs = new FileStream("ser.xml", FileMode.Create))
            {
                serializer.WriteObject(fs, symb);
            }
            using (FileStream fs = new FileStream("ser.xml", FileMode.Open))
            {
                symb2 = (ConsoleSymbolStruct[])serializer.ReadObject(fs);
            }
            Array.ForEach(symb2, x => Console.WriteLine(x));
            Console.WriteLine();
        }
    }
}
