namespace OOP.Interfaces
{
    using System.Collections.Generic;

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
                var shapeArea = shape.CalculateArea();
                System.Console.WriteLine($"Area lui: {shape.Name} este: {shapeArea}");
            }
        }
    }
}