namespace OOP.AbstractClasses
{
    public class Square : Shape
    {
        private readonly int l;

        public Square(int l) : base("default")
        {
            this.l = l;
        }

        public override double CalculateArea()
        {
            return this.l * this.l;
        }
    }
}