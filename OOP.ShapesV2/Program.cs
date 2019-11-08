namespace OOP.Shapes.Ex05.Home
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(1, 3);
            //Console.WriteLine(t.CalculateSurface());

            Rectangle r = new Rectangle(2, 3);
            //Console.WriteLine(r.CalculateSurface());

            Square s = new Square(5);
            //Console.WriteLine(s.CalculateSurface());

            List<Shape> shapes = new List<Shape>();

            shapes.Add(s);
            shapes.Add(t);
            shapes.Add(r);

            foreach (var shape in shapes)
            {
                // polimorfism - CalculateSurface are implementare diferita, in functie de context
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
