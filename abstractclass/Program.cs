using System;

public abstract class Shape
{
    protected int x;
    protected int y;
    
    public abstract int Area();
}

public class Rectangle : Shape
{    
    public Rectangle(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override int Area()
    {
        return this.x * this.y;
    }
}

public class Square : Shape 
{
    public Square(int x)
    {
        this.x = x;
    }

    public override int Area()
    {
        return this.x * this.x;
    }
}

public class Polymorphism
{
    static void Main()
    {
        Shape[] shapes = { new Square(5), 
            new Rectangle(9, 4), new Square(12) }; 

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Area());
        }
    }
}

