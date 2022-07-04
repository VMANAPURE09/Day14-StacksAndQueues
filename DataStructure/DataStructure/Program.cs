using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(3);
            st.Push(56);
            st.Push(30);
            st.Push(70);
            Console.WriteLine(st.ToString());
        }
    }
}
