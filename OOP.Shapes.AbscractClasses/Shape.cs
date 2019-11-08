namespace OOP.AbstractClasses
{
    using System;

    public abstract class Shape
    {
        protected string Name;

        protected Shape(string name)
        {
            this.Name = name;
        }

        public abstract double CalculateArea();

        public void PrintArea()
        {
            Console.WriteLine($"My area is {this.CalculateArea()}");
        }
    }
}