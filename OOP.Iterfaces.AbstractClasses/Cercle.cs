using System;

namespace OOP.Iterfaces.AbstractClasses
{
    public class Cercle : IShape
    {
        int r;

        public Cercle(int r)
        {
            this.r = r;
        }

        public string Name => "Cercle";

        public double CalculateArea()
        {
            return Math.PI * r * r;
        }
    }
}
