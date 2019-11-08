namespace OOP2.Student.Teacher
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student()
            {
                Id = "1",
                Name = "and",
                Grade = "1A"
            };

            var t = new Teacher()
            {
                Id = "2",
                Name = "mis",
                Salary = "23"
            };

            var personManger = new PersonManager();

            personManger.Add(s);
            personManger.Add(t);
        }

        //static void PrintPerson(Person p)
        //{
        //    System.Console.WriteLine($"{p.Id} - {p.Name} - {p.GetType().FullName}");
        //}
    }

    public class PersonManager
    {
        private readonly List<Person> personList;

        public PersonManager()
        {
            this.personList = new List<Person>();
        }

        public void Add(Person p)
        {
            this.personList.Add(p);
        }
    }
}
