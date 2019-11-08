namespace OOP.ShapesV2
{
    class Square : Shape
    {
        public Square(int l) : base(l, l)
        {
        }

        public override double CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}