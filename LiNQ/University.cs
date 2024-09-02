using static System.Console;

namespace Section17.LiNQ
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
            => WriteLine($"University {Name} with id {Id}");
    }
}
