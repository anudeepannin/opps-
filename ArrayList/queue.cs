using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class queue
    {
		public static void Main()
		{
			Queue<string> strQ = new Queue<string>();
			strQ.Enqueue("B");
			strQ.Enqueue("H");
			strQ.Enqueue("A");
			strQ.Enqueue("V");
			strQ.Enqueue("N");
			strQ.Enqueue("A");

			Console.WriteLine("Total elements: {0}", strQ.Count);
			if (strQ.Count > 0)
			{
				Console.WriteLine(strQ.Peek());
				Console.WriteLine(strQ.Peek());
			}
			Console.WriteLine("------Printing----");

			while (strQ.Count > 0)
				Console.WriteLine(strQ.Dequeue()); 

			Console.WriteLine("Total elements: {0}", strQ.Count);

			
		}
	}
}
