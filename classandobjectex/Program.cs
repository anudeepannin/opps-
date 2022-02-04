using System;
namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator cal= new Calculator();

            
            int result = cal.Sum(10, 20);

            Console.WriteLine("Output of the Program="+result);
            Console.ReadKey();
        }
    }

  
    public class Calculator
    {
        public int Sum(int no1, int no2)
        {
            return no1 + no2;
        }
    }
}