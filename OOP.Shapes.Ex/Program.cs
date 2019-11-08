namespace OOP.Employees.Ex
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            //var employee = new Employee
            //{
            //    Id = "0",
            //    Name = "Dan",
            //    BirthDate = new DateTime(1975, 3, 1),
            //    BaseSalary = 10000
            //};

            List<Employee> employees = new List<Employee>();

            Employee director = new Director
            {
                Id = "1",
                Name = "Popescu",
                BirthDate = new DateTime(1950, 3, 1),
                BaseSalary = 10000
            };


            Employee superDirector = new SuperDirector
            {
                Id = "1",
                Name = "Tata lui Popescu",
                BirthDate = new DateTime(1930, 3, 1),
                BaseSalary = 10000
            };

            Employee developer = new Developer
            {
                Id = "2",
                Name = "Hagi",
                BirthDate = new DateTime(1985, 3, 1),
                BaseSalary = 1000
            };

            employees.Add(director);

            employees.Add(superDirector);

            employees.Add(developer);

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name }: {employee.CalculateSalary()}" +
                                  $" (age {employee.CalculateAge()}) (type: {employee.GetEmployeeType()})");
            }

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine($"{director.Name }: {director.CalculateSalary()} (age {director.CalculateAge()})");
            //Console.WriteLine($"{developer.Name }: {developer.CalculateSalary()} (age {developer.CalculateAge()})");
        }
    }
}
