namespace Section8._Inheritance.EmployeeDemo
{
    internal class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeId { get; private set; }

        public Employee(string name, int age, string jobTitle, int employeeId)
            : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            Console.WriteLine("Employee constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job title {JobTitle}, Employee ID {EmployeeId}");
        }
    }
}
