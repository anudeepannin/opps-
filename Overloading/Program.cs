using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OverloadingExample
{
    class Demo
    {
        public int Sum(int area1, int area2, int area3)
        {
            int value = area1 + area2 + area3;
            return value;
        }
        public double Sum(double money1, double money2, double money3)
        {
            double value = money1* money2*money3;
            return value;
        }
        public static void Main(string[] args) 
        {
            Demo d = new Demo();
            int sum1 = d.Sum(24, 28, 7);
            Console.WriteLine("sum of the Areas " + " value : " + sum1);
            double sum2 = d.Sum(10.0, 20.0, 30.0);
            Console.WriteLine("sum of the Multipication of the Money" + " value : " + sum2);
            Console.ReadLine();
        }
    }
}
