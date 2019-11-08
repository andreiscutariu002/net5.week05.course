namespace OOP.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ShapeManager();

            manager.Add(new Square(3));
            manager.Add(new Circle(3));
            manager.Add(new Square(4));
            manager.Add(new Rectangle(2, 4));

            manager.PrintAllAreas();
        }
    }
}
