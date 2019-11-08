namespace OOP.Interfaces
{
    public class Rectangle : IShape, IPolygon
    {
        readonly int lung;
        readonly int lat;

        public Rectangle(int lung, int lat)
        {
            this.lung = lung;
            this.lat = lat;
        }

        public string Name
        {
            get
            {
                return "Rectangle";
            }
        }

        public int NumberOfSides
        {
            get
            {
                return 4;
            }
        }

        public double CalculateArea()
        {
            return this.lung * this.lat;
        }
    }
}
