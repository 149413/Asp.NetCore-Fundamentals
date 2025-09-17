using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assian01.Models
{
    internal class Department
    {
        // By Data Annotation
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }
        [Required]
        [StringLength(50)]
        [Column("DeptName", TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? HiringDate { get; set; }





        // F.K
        [ForeignKey(nameof(Manager))]  // Pass Navigation
        public int MangerId { get; set; } // Mange





        // Navigation Property
        public List<Student> Students { get; set; } // LearnIn
        public Instructor Manager { get; set; } // Mange
        public List<Instructor> Instructors { get; set; } // WorkFor



    }
}
