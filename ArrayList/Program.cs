using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("fun");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(1.9);
            arlist1.Add(null);

            var arlist2 = new ArrayList()
                    {
                        2, "ram", true, 2.9, null
                    };
            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);
            }


            Console.WriteLine("ArrayList 2 Elements");

            for (int i = 0; i < arlist2.Count; i++)
            {
                Console.WriteLine(arlist2[i]);
            }
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2);
            arlist1.AddRange(arr);
            arlist1.AddRange(myQ);
            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);

            }

        }
    }
}
