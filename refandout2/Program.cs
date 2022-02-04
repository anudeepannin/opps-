using System;
class Program
{
    static void Main()
    {
        int number = 8;
        Increase(number);
        Console.WriteLine(number); 
        var man = new User { Name = "man", Salary = 50000 };
        Promote(man);
        Console.WriteLine(man.Salary); 
        Leave(man);
        Console.WriteLine(man.Salary); 

        LeaveByRef(ref man);
        Console.WriteLine(man?.Salary); 

        User rav;
        Hire(out rav);
        Console.WriteLine(rav.Salary); 
    }
    static void Increase(int num)
    {
        num = num + 1;
        Console.WriteLine(num); 
    }
    static void Promote(User u)
    {
        u.Salary += 10000;
        Console.WriteLine(u.Salary); 
    }
    static void Leave(User u)
    {
        u = null;
    }
    static void LeaveByRef(ref User u)
    {
        u = null;
    }
    static void Hire(out User u)
    {
        u = new User
        {
            Name = "man",
            Salary = 50000
        };
    }
}
class User
{
    public string Name { get; set; }
    public int Salary { get; set; }
}