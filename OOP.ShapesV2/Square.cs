namespace OOP.Shapes.Ex05.Home
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