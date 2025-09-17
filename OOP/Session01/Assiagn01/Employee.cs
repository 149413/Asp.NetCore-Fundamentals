
using Assiagn01.Models;

namespace Assiagn01
{

    enum Role
    {
        Guest = 1,
        Developer,
        Secretary,
        DBA,
        Officer
    }


    [Flags]
    enum Permissions : byte
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        Delete = 8,
    }


    //ID, Name, security level, salary, hire date and Gender.
    internal class Employee
    {

        #region Content
        /* 1.Design and implement a Class for the employees in a company: 
            Notes: 
            ● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            ● We need to restrict the Gender field to be only M or F[Male or Female]  
           // ● Assign the following security privileges to the employee(guest,
            Developer, secretary and DBA) in a form of Enum.
            ● We want to provide the Employee Class to represent Employee data in a
            string Form(override ToString()), display employee salary in a currency
            format. [Use String.Format() Function].*/



        /* 0.Develop a Class to represent the Hiring Date Data: 
           ● Consisting of fields to hold the day, month and Years.
           0.
           Create an array of Employees with size three a DBA, Guest and
           the third one is security officer who have full permissions. (Employee
           [] EmpArr;) 
           Notes:
           ● Implement All the Necessary Member Functions on the Class
           (Getters, Setters)
           //● Define all the Necessary Constructors for the Class 
           ● Allow NO RUNTIME errors if the user inputs any data 
           ● Write down all the necessary Properties(Instead of setters
           and getters)*/
        #endregion


        #region Attributes
        private int id;
        private string name;
        private Permissions permission; // read-Only
        private decimal salary;
        private HiringDate hireDate;
        private char gender;
        private Role roleEmployee;
        #endregion


        #region Setter Functions

        // Setter
        public void SetId()
        {
            bool flag = false;
            do
            {
                Console.Write("enter Id: ");
                flag = int.TryParse(Console.ReadLine(), out id);
            } while (!flag || Id < 0);

        }
        public void SetName()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
        }

        public void SetGender()
        {
            bool flag;
            do
            {
                Console.Write("Enter Gender  M/F: ");
                flag = char.TryParse(Console.ReadLine(), out gender);
            } while (!flag || gender != 'M' || gender != 'F' || gender != 'm' || gender != 'f');
        }

        public void SetSalary()
        {
            bool flag = false;
            do
            {
                Console.Write("Enter Salary: ");
                flag = decimal.TryParse(Console.ReadLine(), out salary);
            } while (!flag || salary < 0);
        }

        public void SetHireDate()
        {
            Console.Write("Day:");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            hireDate = new HiringDate(day, year, month);
        }

        public void SetRoleEmplyee()
        {
            bool flag;
            object O1;
            do
            {
                flag = Enum.TryParse(typeof(Role), Console.ReadLine(), true, out O1);
            } while (!flag);
            roleEmployee = O1 is not null ? (Role)O1 : 0;
        }

        public void SetPermission()
        {
            if (Enum.IsDefined(typeof(Role), roleEmployee))
            {
                switch (roleEmployee)
                {
                    case Role.Guest:
                        permission = Permissions.Read;
                        break;

                    case Role.Developer:
                    case Role.Secretary:
                        permission = Permissions.Read | Permissions.Write;
                        break;

                    case Role.DBA:
                        permission = Permissions.Read | Permissions.Write | Permissions.Execute;
                        break;

                    case Role.Officer:
                        permission = Permissions.Read | Permissions.Write | Permissions.Delete | Permissions.Execute;
                        break;

                    default:
                        permission = Permissions.None;
                        break;
                }
            }
            else
            {
                permission = Permissions.None;
            }
        }

        #endregion

        #region Getter Functions
        // Getter
        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public char GetGenser()
        {
            return gender;
        }
        public decimal GetSalary()
        {
            return Salary;
        }

        public DateTime GetHirngDate()
        {
            return Convert.ToDateTime(hireDate);
        }

        public Role GetRoleEmplyee()
        {
            return roleEmployee;
        }

        public Permissions GetPermission()
        {
            return permission;
        }
        #endregion


        #region Properties


        public int Id
        {
            get { return id; }
            set
            {
                {
                    if (value >= 0)
                        id = value;
                    else
                        throw new ArgumentException("ID must be non-negative.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    throw new ArgumentException("Name cannot be empty.");
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                {
                    if (value >= 0)
                        salary = value;
                    else
                        throw new ArgumentException("ID must be non-negative.");
                }
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {

                if (value != 'M' || value != 'F' || value != 'm' || value != 'f')
                {
                    gender = value;
                }
                else
                    throw new Exception("Invalide Input");
            }
        }

        public HiringDate HireDate
        {
            get { return hireDate; }
            set
            {
                if (value != null)
                    hireDate = value;
                else
                    throw new ArgumentNullException("HiringDate cannot be null.");
            }
        }

        public Role RoleEmplyee
        {
            get { return roleEmployee; }
            set { roleEmployee = value; }
        }

        public Permissions Permission
        {
            get { return permission; }
            set { permission = value; }
        }

        #endregion


        #region Constructor
        public Employee()
        {
            id = 0;
            name = "Unknown";
            permission = Permissions.None;
            salary = 0;
            hireDate = new HiringDate(1, 1, 2000);
            gender = 'M';
            roleEmployee = Role.Guest;
        }

        public Employee(int id, string name, decimal salary, HiringDate hireDate, char gender, Role roleEmployee)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
            this.roleEmployee = roleEmployee;

            SetPermission();
        }
        #endregion


        #region Disp By ToString()

        public override string ToString()
        {
            return String.Format("ID: {0}\nName: {1}\nRole: {2}\nPermission: {3}\nSalary: {4:C}\nHire Date: {5}\nGender: {6}",
                         id, name, roleEmployee, permission, salary, hireDate, gender);
        }
        #endregion







    }
}
