namespace Dem01.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public List<StudentCourse> Students { get; set; }

    }
}
