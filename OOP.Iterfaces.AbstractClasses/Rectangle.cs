namespace OOP.Iterfaces.AbstractClasses
{
    public class Rectangle : IShape, IPolygon
    {
        int lung;
        int lat;

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
            return lung * lat;
        }
    }
}
