using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack st = new Stack(3);
            //st.Push(56);
            //st.Push(30);
            //st.Push(70);
            //Console.WriteLine(st.ToString());
            // Console.WriteLine("The Peek Value is " + st.Peek());

            ///UC3-Queue
            Queue queue = new Queue(3);
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine(queue.ToString());
        }
    }
}
