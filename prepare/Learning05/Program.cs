using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle radius = new Circle("Orange", 10);
        shapes.Add(radius);

        Rectangle sides = new Rectangle("Yellow", 7, 5);
        shapes.Add(sides); 
        
        Square side = new Square("Blue", 8);
        shapes.Add(side);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}