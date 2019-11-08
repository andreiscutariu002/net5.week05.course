namespace OOP.Employees.Ex
{
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

    // nu merge din Developer pt ca este sealed
    //public class SuperDeveloper : Developer
    //{

    //}
}