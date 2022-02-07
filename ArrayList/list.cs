using System;
using System.Collections.Generic;
namespace Arraylist
{
    public class list
    {
        public static void Main()
        {
            //Generic Collections List
            var num = new List<int>();
            num.Add(1);
            num.Add(3);
            num.Add(5);
            num.Add(7);

            Console.WriteLine("No of elelemts: " + num.Count);

            var cities = new List<string>();
            cities.Add("India");
            cities.Add("Hyderabad");
            cities.Add("Mumbai");
            cities.Add("Nodia");
            cities.Add(null);

            Console.WriteLine("No of elelemts: " + cities.Count);


            var bigCities = new List<string>() { "India", "Hyderabad", "Mumbai", "Nodia" };

            Console.WriteLine("No of elelemts: " + bigCities.Count);

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="bunny"},
                new Student(){ Id = 2, Name="sunny"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="mam"}
            };

            Console.WriteLine("No of elelemts: " + students.Count);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}