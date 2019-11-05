namespace OOP2.Human.Worker.Students
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHourPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHourPerDay;
        }

        public int WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public float MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }
    }
}
