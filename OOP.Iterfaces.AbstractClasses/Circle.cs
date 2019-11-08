namespace OOP.Interfaces
{
    using System;

    public class Circle : IShape
    {
        readonly int r;

        public Circle(int r)
        {
            this.r = r;
        }

        public string Name => "Cercle";

        public double CalculateArea()
        {
            return Math.PI * this.r * this.r;
        }
    }
}
