namespace OOP2.Human.Worker.Students
{
    public class Student : Human
    {
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
        
        public string Grade { get; set; }
    }
}
