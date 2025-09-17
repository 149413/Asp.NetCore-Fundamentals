namespace Dem01.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<StudentCourse> Students { get; set; }



    }

}
