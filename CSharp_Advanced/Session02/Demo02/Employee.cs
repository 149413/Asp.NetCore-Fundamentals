using System.Collections;

namespace Demo02
{
    class EmployeeIComparerSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            return X.Salary.CompareTo(Y.Salary);
        }
    }
    //class EmployeeIComparerName : IComparer
    //{
    //    public int Compare(object? x, object? y)
    //    {
    //        Employee X = (Employee)x;
    //        Employee Y = (Employee)y;
    //        return X.Name.CompareTo(Y.Name);
    //    }
    //}
    class EmployeeIComparerName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            return Age.CompareTo(other.Age);
        }


        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Salary: {Salary} , Age: {Age}\n";
        }
    }
}
