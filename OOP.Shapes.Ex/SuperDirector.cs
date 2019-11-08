namespace OOP.Employees.Ex
{
    public class SuperDirector : Director
    {
        // nu merge pt ca metoda ToString din Director este sealed
        //public override string ToString()
        //{
        //    return "Super Dir. " + this.Name + " " + this.CalculateAge();
        //}
    }
}