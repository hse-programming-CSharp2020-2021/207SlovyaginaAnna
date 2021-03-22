using System;

namespace Street
{
    public class Streets
    {
        public string Name { get; set; }
        public int[] Houses { get; set; }
        public static int operator ~(Streets st)
        {
            return st.Houses.Length;
        }
        public static bool operator +(Streets st)
        {
            foreach (char c in st.Houses)
            {
                if (c.ToString().Contains("7"))
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            string info = string.Join(" ", Houses);
            return Name + " " + info;
        }
    }
}
