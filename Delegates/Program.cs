using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void MyDelegate(int a, int b);

    public class Eventclass
    {
        public event MyDelegate MyEvent;

        public void RaiseEvent(int a, int b)
        {
            MyEvent(a, b);
            Console.WriteLine("Event Perfomed");
        }

        public void Add(int x, int y)
        {
            Console.WriteLine("Add Method {0}", x + y);
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Method {0}", x - y);
        }

        static void Main(string[] args)
        {

            Eventclass e = new Eventclass();
            e.MyEvent += new MyDelegate(e.Add);
            e.MyEvent += new MyDelegate(e.Subtract);
            e.RaiseEvent(20, 10);
            Console.ReadLine();
        }
    }


}







