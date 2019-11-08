namespace OOP.Employees.Ex
{
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
}