namespace OOP2.Human.Worker.Students
{
    public class Human
    {
        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected string Age { get; set; }
    }
}
