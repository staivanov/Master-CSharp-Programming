using static System.Console;

namespace Section17.LiNQ
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreign Key
        public int UniversityId { get; set; }

        public void Print()
            => WriteLine($"Student {Name} with id {Id} from University with the Id {UniversityId}.");
    }
}
