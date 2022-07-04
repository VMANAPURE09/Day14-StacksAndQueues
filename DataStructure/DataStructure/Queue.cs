using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        int capacity;
        int[] obj;
        int front = -1, rear = -1;
        public Queue(int capacity)
        {
            this.capacity = capacity;
            obj = new int[capacity];
        }
        public bool Enqueue(int data)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Que is Full");
                return false;
            }
            if (rear == -1)
                front++;
            obj[++rear] = data;
            return true;
        }
        public override string ToString()
        {
            String s = "";
            for (int i = front; i <= rear && front != -1; i++)
            {
                s = s + obj[i] + " ";

            }
            return s;
        }

    }
}
