using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack
    {
		int capacity;
		int[] obj;
		int top = -1;
		public Stack(int capacity)
		{
			this.capacity = capacity;
			obj = new int[capacity];
		}
		public bool Push(int data)
		{
			if (top == capacity - 1)
			{
				Console.WriteLine("Stack overFlow.");
				return false;
			}
			obj[++top] = data;
			return true;
		}
		public override string ToString()
		{
			String s = "";
			for (int i = 0; i < capacity; i++)
			{
				s = s + obj[i];
			}
			return s;
		}
	}
}
