using System;

namespace OOP2.Overloading
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        internal string Add(string v1, string v2)
        {
            return $"{v1}{v2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();

            var a = c.Add(1, 2);
            System.Console.WriteLine(a);

            var b = c.Add(1.2, 3);
            System.Console.WriteLine(b);

            var d = c.Add("a", "b");
            System.Console.WriteLine(d);
        }
    }
}
