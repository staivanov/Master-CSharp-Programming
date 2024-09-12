using System.Xml.Linq;
using static System.Console;


namespace Section17.LiNQwithXML
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Ascending order of the students:");
            PrintStudents(OrderStudents());
            WriteLine("--------------------------------");
            WriteLine("Descending order of the students: ");
            PrintStudents(OrderStudents(descOrder: true));
        }

        private static XDocument GetStudentsFromXMLfile()
        {
            XDocument studentsXdoc = new();
            string studentsOnXML = XMLdataSeed.GetXMLdata();
            studentsXdoc = XDocument.Parse(studentsOnXML);

            return studentsXdoc;
        }

        private static IEnumerable<dynamic> GetStudents()
        {
            XDocument studentsXdoc = GetStudentsFromXMLfile();

            string descendantElement = "Student",
                   name = "Name",
                   age = "Age",
                   university = "University",
                   semester = "Semester";

            var students = from student
                           in studentsXdoc.Descendants(descendantElement)
                           select new
                           {
                               Name = student.Element(name)?.Value,
                               Age = student.Element(age)?.Value,
                               University = student.Element(university)?.Value,
                               Semester = student.Element(semester)?.Value
                           };

            return students;
        }

        private static void PrintStudents(IEnumerable<dynamic> students)
        {
            string message = string.Empty;

            foreach (dynamic student in students)
            {
                message = $"Student {student.Name} with age {student.Age} from University {student.University}.";
                WriteLine(message);
            }
        }

        private static IEnumerable<dynamic> OrderStudents(bool descOrder = false)
        {
            string descendantElement = "Student",
                 name = "Name",
                 age = "Age",
                 university = "University",
                 semester = "Semester";

            XDocument studentsXdoc = GetStudentsFromXMLfile();
            IEnumerable<dynamic> students;

            if (descOrder)
            {
                students = from student
                           in studentsXdoc.Descendants(descendantElement)
                           orderby student.Element(age)?.Value descending
                           select new
                           {
                               Name = student.Element(name)?.Value,
                               Age = student.Element(age)?.Value,
                               University = student.Element(university)?.Value,
                               Semester = student.Element(semester)?.Value
                           };

                return students;
            }

            students = from student
                       in studentsXdoc.Descendants(descendantElement)
                       orderby student.Element(age)?.Value ascending
                       select new
                       {
                           Name = student.Element(name)?.Value,
                           Age = student.Element(age)?.Value,
                           University = student.Element(university)?.Value,
                           Semester = student.Element(semester)?.Value
                       };

            return students;
        }
    }
}
