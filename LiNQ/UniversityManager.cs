using static System.Console;

namespace Section17.LiNQ
{
    public class UniversityManager
    {
        private List<University> _universities;
        private List<Student> _students;

        public UniversityManager()
        {
            _universities = new(DataSeed.AddUniversities());
            _students = new(DataSeed.AddStudents());
        }

        public void MaleStudents()
        {
            string maleGender = "male";
            IEnumerable<Student> maleStudents = from student in _students
                                                where student.Gender == maleGender
                                                select student;

            WriteLine("Male - Students");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            string femaleGender = "female";
            IEnumerable<Student>? femaleStudents = from student in _students
                                                   where student.Gender == femaleGender
                                                   select student;
            WriteLine("Female - Students");

            foreach (Student femaleStudent in femaleStudents)
            {
                femaleStudent.Print();
            }
        }

        public void SortStudentByAge(bool descSort = false)
        {
            IEnumerable<Student>? students;

            if (descSort)
            {
                students = from student in _students
                           orderby student.Age descending
                           select student;
            }
            else
            {
                students = from student in _students
                           orderby student.Age
                           select student;
            }

            WriteLine("Student sorted by Age:");

            foreach (Student student in students)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            string beijingUniversity = "Beijing Tech";

            IEnumerable<Student> bjtStudents = from student in _students
                                               join university in _universities
                                               on student.UniversityId equals university.Id
                                               where university.Name == beijingUniversity
                                               select student;

            WriteLine("Students from Beijing Tech");

            foreach (Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in _students
                                join university in _universities
                                on student.Id equals university.Id
                                orderby student.Name
                                select new
                                {
                                    StudentName = student.Name,
                                    UniversityName = university.Name
                                };

            WriteLine("New Collection");

            foreach (var col in newCollection)
            {
                string message = $"Student {col.StudentName} at University {col.UniversityName}";
                WriteLine(message);
            }
        }




    }
}
