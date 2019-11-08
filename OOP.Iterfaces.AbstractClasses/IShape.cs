namespace OOP.Interfaces
{
    using System.Collections.Generic;

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
            this.shapes = new List<IShape>();
        }

        public void Add(IShape s)
        {
            this.shapes.Add(s);
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
