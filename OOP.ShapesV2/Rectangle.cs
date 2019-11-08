namespace OOP.ShapesV2
{
    class Rectangle : Shape
    {
        public Rectangle(int lat, int lon) : base(lat, lon)
        {
        }

        public override double CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}