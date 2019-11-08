namespace OOP.Shapes.Ex05.Home
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