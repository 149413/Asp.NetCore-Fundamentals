namespace Demo03.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;



        public virtual List<Employee> Employees { get; set; }
    }
}
