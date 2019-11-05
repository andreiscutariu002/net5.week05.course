using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Human.Worker.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Andrei", "Sct");

            var superStudent = new SuperStudent("Andrei", "Sct");

            var worker = new Worker("And", "Sct2", 100, 5);
        }
    }
}
