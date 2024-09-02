namespace Section17.LiNQ
{
    public class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new(DataSeed.AddUniversities());
            students = new(DataSeed.AddStudents());
        }

        public void MaleStudents()
        {
            string maleGender = "male";
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == maleGender
                                                select student;

            Console.WriteLine("Male - Students");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            string femaleGender = "female";
            IEnumerable<Student>? femaleStudents = from student in students
                                                   where student.Gender == femaleGender
                                                   select student;
            Console.WriteLine("Female - Students");

            foreach (Student femaleStudent in femaleStudents)
            {
                femaleStudent.Print();
            }
        }
    }
}
