namespace OOP.ShapesV2
{
    class Triangle : Shape
    {
        public Triangle(int w, int h) : base(w, h)
        {
        }

        public override double CalculateSurface()
        {
            return this.height * this.width / (double)2;
        }
    }
}