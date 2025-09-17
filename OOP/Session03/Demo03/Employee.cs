using System.Collections;

namespace Demo03
{

    class EmployeeComparerSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if (X.Salary > Y.Salary)
                return 1;
            else if (X.Salary < Y.Salary)
                return -1;
            else
                return 0;

            // return X.CompareTo(Y);
        }
    }
    class EmployeeComparerNameLength : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if (X.Name.Length > Y.Name.Length)
                return 1;
            else if (X.Name.Length < Y.Name.Length)
                return -1;
            else
                return 0;

            // return X.CompareTo(Y);
        }
    }

    internal class Employee : IComparable  /* : ICloneable */
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee()
        {

        }
        public object Clone() // Deep Copy
        {
            return new Employee(this);  // Syntax Suger : By Copy Constructor
            //return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }

        // Copy Constructor
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Age = employee.Age;
            Salary = employee.Salary;
        }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , age: {Age} , Salary: {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee emp = (Employee)obj;
            //if (this.Age > emp.Age) return 123;
            //else if (this.Age < emp.Age) return -1123;
            //else return 0;

            return this.Age.CompareTo(emp.Age);  // Syntax Suger
        }
    }
}
