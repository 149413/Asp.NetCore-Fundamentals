namespace Assian01.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // 1 ----> M
        public List<Course> Couses { get; set; }

    }
}
