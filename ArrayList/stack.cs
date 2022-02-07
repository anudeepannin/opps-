using System;
using System.Collections;
using System.Collections.Generic;


namespace Arraylist
{
    class stack
    {
		public static void Main()
		{
			Stack<int> numbers = new Stack<int>();
			numbers.Push(1);
			numbers.Push(2);
			numbers.Push(3);
			numbers.Push(4);

			foreach (var item in numbers)
				Console.Write(item + ",");
			int[] arr = new int[] { 1, 2, 3, 4 };
			Stack<int> myStack = new Stack<int>(arr);

			foreach (var itm in myStack)
				Console.Write(itm + ",");
			Stack newStack = new Stack();
			newStack.Push(1);
			newStack.Push(2);
			newStack.Push(3);
			newStack.Push(4);

			Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

			while (myStack.Count > 0)
				Console.Write(myStack.Pop() + ",");

			Console.WriteLine();
			Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
		}
	}
}
