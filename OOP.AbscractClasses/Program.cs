using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbscractClasses
{
    public abstract class Shape
    {
        protected string name;

        protected Shape(string name)
        {
            this.name = name;
        }

        public abstract double CalculateArea();

        public void PrintArea()
        {
            Console.WriteLine($"My area is {this.CalculateArea()}");
        }
    }

    public class Square : Shape
    {
        int l;

        public Square(int l) : base("default")
        {
            this.l = l;
        }

        public override double CalculateArea()
        {
            return l * l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(3);

            square.PrintArea();
        }
    }
}
