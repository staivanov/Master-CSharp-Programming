namespace Section8._Inheritance.EmployeeDemo
{
    internal class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int age, string jobTitle, int employeeId, int teamSize)
            : base(name, age, jobTitle, employeeId)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
