namespace Section8._Inheritance.EmployeeDemo
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Public constructor called.");
        }


        public void DisplayPersonInfo()
        {

        }
    }
}
