using System;
using System.Collections;
using System.Collections.Generic;


namespace Arraylist
{
    class hashtable
    {

		public static void Main()
		{
			Hashtable empinfo = new Hashtable();
			empinfo.Add(1, "emp1"); 
			empinfo.Add(2, "emp2");
			empinfo.Add(3, "emp3");

			foreach (DictionaryEntry kvp in empinfo)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);		
			var phones = new Hashtable(){
			{"apple", "iphone11, iphone12, iphone13"},
			{"mi", "Remdi9,  Remdi10, Remdi11"},
			{"onepluse", "nord1, nord2, nord3"}
		};

			foreach (DictionaryEntry kvp in phones)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		}
	}
}
