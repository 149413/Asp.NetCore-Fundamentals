using System.ComponentModel.DataAnnotations.Schema;

namespace Assian01.Models
{
    // by Class Configuration
    internal class Instructor
    {
        public int Ins_Id { get; set; }
        public string Name { get; set; }
        public double? Bouns { get; set; }
        public double Salary { get; set; }
        public double? HourRate { get; set; }

        // F.K
        public int? Dept_Id { get; set; } // WorkFor



        // Navigation Property
        [InverseProperty(nameof(Department.Manager))]
        public Department? Department { get; set; } // Mange
        public Department? WorkFor { get; set; } // WorkFor

        public List<Course_Ins> Courses { get; set; }



    }
}
