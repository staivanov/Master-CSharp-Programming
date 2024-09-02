namespace Section17.LiNQ
{
    public static class DataSeed
    {
        public static List<Student> AddStudents()
        {
            List<Student> students = new()
            {
                new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 },
                new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 },
                new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 },
                new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 },
                new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 },
                new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 },
            };

            return students;
        }


        public static List<University> AddUniversities()
        {
            List<University> universities = new() {

            new University { Id = 1, Name = "Yale" },
            new University { Id = 2, Name = "Beijing Tech" },
            };

            return universities;
        }
    }
}
