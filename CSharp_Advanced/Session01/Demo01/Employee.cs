namespace Demo01
{
    public class EmployeeICompatableCompare : IEqualityComparer<Employee>
    {
        bool IEqualityComparer<Employee>.Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        int IEqualityComparer<Employee>.GetHashCode(Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }

    class EmployeeIcomparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
    class EmployeeIcomparerNameLength : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }


    internal class Employee : IComparable /*<Employee>*/ , IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {

        }

        #region Equality in Class && Struct
        // Operator Oveloading ==
        public static bool operator ==(Employee left, Employee Right)
        {
            return left.Id == Right.Id && left.Name == Right.Name && left.Age == Right.Age && left.Salary == Right.Salary;
        }
        public static bool operator !=(Employee left, Employee Right)
        {
            return left.Id != Right.Id || left.Name != Right.Name || left.Age != Right.Age || left.Salary != Right.Salary;
        }

        public override bool Equals(object? obj)
        {
            Employee E = obj as Employee;
            return this == E;
        }

        #endregion


        #region Non Genasric And Genaric IComparable

        public int CompareTo(object? obj)
        {
            // By as Casting Operator
            Employee E = obj as Employee;
            if (E is not null)
            {
                return Age.CompareTo(E.Age);
            }
            return 1;
        }

        public int CompareTo(Employee? other)
        {
            if (other is not null)
            {
                return Age.CompareTo(other.Age);
            }
            return 1;
        }

        #endregion
        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Salary: {Salary} , Age: {Age}";
        }

        #region Buil-in Interface IEquatable
        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;
        }
        #endregion

    }


}
