namespace Assian01.Models
{
    internal class Course
    {
        // by Flaunt API
        public int CId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Duration { get; set; }




        //F.K
        public int Top_Id { get; set; }




        public Topic Topic { get; set; }

        public List<Stud_Course> Students { get; set; }

        public List<Course_Ins> Instructors { get; set; }


    }
}
