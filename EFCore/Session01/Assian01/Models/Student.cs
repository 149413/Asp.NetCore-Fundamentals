using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assian01.Models
{

    // By Convention
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }


        // F.K
        [ForeignKey(nameof(LearnIn))]
        public int? Dept_ID { get; set; }

        // 1 ----> M

        public Department? LearnIn { get; set; }
        public List<Stud_Course> Courses { get; set; }





        //public override string ToString()
        //{
        //    return $"Id: {Id}\n" +
        //           $"{FName} - {LName} - {Address} - {Age} - {Dept_ID}\n" +
        //           $"Dept_Iid: {Dept_ID}\n" +
        //           $"{LearnIn.Name} - {LearnIn.Instructors[LearnIn.DeptId].Name}";
        //}


    }
}
