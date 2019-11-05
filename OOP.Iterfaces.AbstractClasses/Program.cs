using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Iterfaces.AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ShapeManager();

            manager.Add(new Square(3));
            manager.Add(new Cercle(3));
            manager.Add(new Square(4));
            manager.Add(new Rectangle(2, 4));

            manager.PrintAllAreas();
        }
    }
}
