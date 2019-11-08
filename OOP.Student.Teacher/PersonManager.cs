namespace OOP.Student.Teacher
{
    using System.Collections.Generic;

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