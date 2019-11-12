using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.OperatorsOverloading
{
    // +, -
    class Point
    {
        double x;

        double y;
    }

    class Rate
    {
        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; }

        public static Rate Add(Rate a, Rate b)
        {
            return new Rate
            {
                Amount = a.Amount + b.Amount,
                CurrencyCode = a.CurrencyCode
            };
        }

        // unar
        public static Rate operator ++(Rate a)
        {
            return new Rate { Amount = a.Amount + 1, CurrencyCode = a.CurrencyCode };
        }

        // aritmetic
        public static Rate operator +(Rate a, Rate b)
        {
            return new Rate
            {
                Amount = a.Amount + b.Amount,
                CurrencyCode = a.CurrencyCode
            };
        }

        // logic
        public static bool operator <(Rate a, Rate b)
        {
            if (a.Amount < b.Amount) return true;
            return false;
        }

        // logic
        public static bool operator >(Rate a, Rate b)
        {
            if (a.Amount > b.Amount) return true;
            return false;
        }

        public override string ToString()
        {
            return $"Rate: {this.Amount} {this.CurrencyCode}";
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var rate2 = new Rate { Amount = 20, CurrencyCode = "EUR" };

            //var rate3 = rate1 + rate2;

            ////if (rate1 < rate2)
            ////{

            ////}

            //int x = 0;
            //x++; // x = x + 1;

            var rate1 = new Rate { Amount = 50, CurrencyCode = "EUR" };
            var rate2 = new Rate { Amount = 20, CurrencyCode = "EUR" };

            rate1++;

            if(rate1 < rate2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            //var rate4 = Rate.Add(rate1, rate2);
        }
    }
}
