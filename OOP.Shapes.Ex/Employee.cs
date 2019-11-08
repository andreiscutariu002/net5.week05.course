namespace OOP.Employees.Ex
{
    using System;

    public abstract class Employee 
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal BaseSalary { get; set; }

        public int CalculateAge()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }

        public virtual decimal CalculateSalary()
        {
            return this.BaseSalary * (decimal) 0.80;
        }

        public abstract string GetEmployeeType();

        public override string ToString()
        {
            return this.Name + " " + this.CalculateAge();
        }
    }

    public class Director : Employee
    {
        public override string GetEmployeeType()
        {
            return "Director";
        }

        public sealed override string ToString()
        {
            return "Dir. " + this.Name + " " + this.CalculateAge();
        }
    }

    public class SuperDirector : Director
    {
        //public override string ToString()
        //{
        //    return "Super Dir. " + this.Name + " " + this.CalculateAge();
        //}
    }

    public sealed class Developer : Employee
    {
        public override decimal CalculateSalary()
        {
            return this.BaseSalary * (decimal)0.9;
        }

        public override string GetEmployeeType()
        {
            return "Developer";
        }
    }

    //public class SuperDeveloper : Developer
    //{

    //}
}