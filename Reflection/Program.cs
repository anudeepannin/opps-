using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
        }
    }
}
