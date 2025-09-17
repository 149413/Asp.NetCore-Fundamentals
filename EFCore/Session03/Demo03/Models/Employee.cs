namespace Demo03.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }
        public double? Age { get; set; }
        public string Address { get; set; }

        public DateTime HiringDate { get; set; } = DateTime.UtcNow;


        //F.K
        public int Dept_Id { get; set; }


        public virtual Department WorkFor { get; set; }

    }
}
