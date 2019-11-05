using System.Collections.Generic;

namespace OOP.Iterfaces.AbstractClasses
{
    public interface IShape
    {
        double CalculateArea();

        string Name { get; }
    }

    public interface IPolygon
    {
        int NumberOfSides { get; }
    }

    public class ShapeManager
    {
        List<IShape> shapes;

        public ShapeManager()
        {
            shapes = new List<IShape>();
        }

        public void Add(IShape s)
        {
            shapes.Add(s);
        }

        public void PrintAllAreas()
        {
            foreach (var shape in this.shapes)
            {
                System.Console.WriteLine($"Area lui: {shape.Name} este: {shape.CalculateArea()}");
            }
        }
    }
}
