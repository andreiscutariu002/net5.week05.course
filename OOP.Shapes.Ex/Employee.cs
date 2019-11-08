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
}