using Assian01.Data;
using Assian01.Models;

namespace Assian01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD Operations

            using AppDbContext context = new AppDbContext();

            #region Student

            #region Create

            // Create
            Student student1 = new Student()
            {
                FName = "Ahmed",
                LName = "Ali",
                Address = "Cairo",
                Age = 25,
                //Dept_ID = 1,
            };
            Student student2 = new Student()
            {
                FName = "Aya",
                LName = "Mohamed",
                Address = "Alex",
                Age = 24,
                //Dept_ID = 1,
            };
            Student student3 = new Student()
            {
                FName = "Ali",
                LName = "Mohamed",
                Address = "Cairo",
                Age = 22,
                Dept_ID = 6,
            };

            //context.Students.Add(student1);
            //context.Students.Add(student2);
            //context.Students.Add(student3);

            //context.SaveChanges(); 
            #endregion

            #region Retrieve - Select
            // Retreive
            //var result = context.Students.Select(S => new
            //{
            //    S.Id,
            //    S.FName,
            //    S.Address,
            //    S.Age,
            //    S.Dept_ID,
            //    //DepartmentName = S.LearnIn.Name,
            //    //HireDate = S.LearnIn.HiringDate,
            //    //MangeOfDepart = S.LearnIn.Instructors[S.LearnIn.MangerId].Name

            //});
            //var result = context.Students.SelectMany(S => S.LearnIn);

            //var result = context.Students.Where(S => S.Id % 2 == 0).Select(S => new
            //{
            //    S.Id,
            //    S.FName,
            //    S.LName,
            //    S.Address,
            //    S.Age,
            //    S.Dept_ID
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Update
            //// Update
            //var stu = context.Students.FirstOrDefault(S => S.Age == 25);

            //stu.Dept_ID = 3;

            //context.SaveChanges();

            #endregion

            #region Remove
            //var result = context.Students.Where(S => S.Address == "Cairo");

            //context.RemoveRange(result);

            //context.SaveChanges();

            #endregion

            #endregion

            #region Department
            // Create
            Department Dept1 = new Department()
            {
                Name = "HR",
                HiringDate = DateTime.Now,
                MangerId = 1

            };
            Department Dept2 = new Department()
            {
                Name = "CS",
                HiringDate = DateTime.Now,
                MangerId = 3

            };
            Department Dept3 = new Department()
            {
                Name = "AI",
                HiringDate = DateTime.Now,
                MangerId = 2
            };

            //context.Departments.Add(Dept1);
            //context.Departments.Add(Dept2);
            //context.Departments.Add(Dept3);

            //context.SaveChanges();


            #endregion


            #region Instructor

            Instructor instructor1 = new Instructor()
            {
                //Ins_Id; // Identity
                Name = "Ahmed",
                Bouns = 300,
                Salary = 6000,
                HourRate = 6,
                //Dept_Id = 10,
            };
            Instructor instructor2 = new Instructor()
            {
                //Ins_Id; // Identity
                Name = "Mariam",
                Bouns = 400,
                Salary = 7000,
                HourRate = 8,
                //Dept_Id = 10,
            };
            Instructor instructor3 = new Instructor()
            {
                //Ins_Id; // Identity
                Name = "Asaad",
                Bouns = 350,
                Salary = 7500,
                HourRate = 7,
                Dept_Id = 3,
            };



            //context.Instructors.Add(instructor1);
            //context.Instructors.Add(instructor2);
            //context.Instructors.Add(instructor3);

            //context.SaveChanges();

            #endregion

            #region Course

            // Create
            Course course1 = new Course()
            {
                Name = "EF",
                Description = "Entity_Framework",
                Duration = 4,
                Top_Id = 1

            };
            Course course2 = new Course()
            {
                Name = "Kubernats",
                Description = "Containers",
                Duration = 6,
                Top_Id = 2

            };
            Course course3 = new Course()
            {
                Name = "LINQ",
                Description = "Language Integrated Query",
                Duration = 2,
                Top_Id = 1

            };


            //context.Courses.Add(course1);
            //context.Courses.Add(course2);
            //context.Courses.Add(course3);

            //context.SaveChanges();

            #endregion


            #region Topic
            // Create
            Topic Top1 = new Topic() { Name = "Web Dev" };
            Topic Top2 = new Topic() { Name = "Dev Ops" };
            Topic Top3 = new Topic() { Name = "Data Analysis" };

            //context.Topics.Add(Top1);
            //context.Topics.Add(Top2);
            //context.Topics.Add(Top3);

            //context.SaveChanges();


            #endregion


            #region Stud_Course

            // Create
            Stud_Course stud_cour1 = new Stud_Course()
            {
                StudentId = 1,
                CourseId = 1,
                Grade = 95
            };
            Stud_Course stud_cour2 = new Stud_Course()
            {
                StudentId = 1,
                CourseId = 3,
                Grade = 85
            };
            Stud_Course stud_cour3 = new Stud_Course()
            {
                StudentId = 2,
                CourseId = 1,
                Grade = 90
            };


            //context.Stud_Courses.Add(stud_cour1);
            //context.Stud_Courses.Add(stud_cour2);
            //context.Stud_Courses.Add(stud_cour3);


            //context.SaveChanges();

            #endregion



            #region Course_Ins

            Course_Ins Cur_Ins1 = new Course_Ins()
            {
                InstructorId = 1,
                CourseId = 1,
                evaluate = "Excellent"
            };

            Course_Ins Cur_Ins2 = new Course_Ins()
            {
                InstructorId = 2,
                CourseId = 3,
                evaluate = "Excellent"
            };


            //context.Courses_Ins.Add(Cur_Ins1);
            //context.Courses_Ins.Add(Cur_Ins2);


            //context.SaveChanges();




            #endregion


        }
    }
}
