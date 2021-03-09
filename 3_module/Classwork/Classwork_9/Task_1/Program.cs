using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"../../Program.cs", FileMode.Open))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                string text = System.Text.Encoding.Default.GetString(bytes);
                Console.WriteLine(text);
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= '0' && text[i] <= 9)
                        Console.WriteLine(text[i]);
                }
            }
        }
    }
}
