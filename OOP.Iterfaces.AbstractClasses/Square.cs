namespace OOP.Interfaces
{
    public class Square : IShape, IPolygon
    {
        private readonly int l;

        public Square(int l)
        {
            this.l = l;
        }

        public string Name
        {
            get
            {
                return "Square";
            }
        }

        //public int NumberOfSides => 4;

        public int NumberOfSides
        {
            get
            {
                return 4;
            }
        }

        public double CalculateArea()
        {
            return this.l * this.l;
        }
    }
}
