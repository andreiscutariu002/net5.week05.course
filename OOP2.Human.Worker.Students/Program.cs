namespace OOP2.Human.Worker.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Andrei", "Sct");

            var superStudent = new SuperStudent("Andrei", "Sct");

            var worker = new Worker("And", "Sct2", 100, 5);
        }
    }
}
