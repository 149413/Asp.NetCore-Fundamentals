namespace Demo_01
{
    internal struct Employee
    {
        // Camel Case
        private int id;
        private string name;
        private int salary;


        #region Apply Encapsolation User Setter Getter Methods
        // Setter
        public void SetId(int id)
        {
            if (id > 0)
                this.id = id;
        }

        public void SetName(string name)
        {
            if (name.Length > 5 && name.Length < 20)
                this.name = name;
        }
        public void SetSalary(int salary)
        {
            if (salary > 0)
                this.salary = salary;
        }


        // Getter:
        // Anomenoth Method (Syntax Suger)
        public int GetId() => this.id;
        public string GetName() => this.name;
        public int GetSalary() => salary;


        public Employee(int id, string name, int salary)
        {
            SetId(id);
            SetName(name);
            SetSalary(salary);
        }

        public override string ToString()
        {
            return $"Id: {id} :: Name: {name} :: Salary: {salary} :: Address: {address} ";
        }

        #endregion


        // Apply Encapsolation User Proerties

        // 1. Full property ---> If You Need Logic


        // By Pascal Case
        public int Id  // read-only
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                if (value.Length > 5 && value.Length < 20)
                    this.name = value;
            }
            get
            {
                return name;
            }
        }

        public int Salary
        {
            set
            {
                if (value > 0)
                    this.salary = value;
            }
            get
            {
                return salary;
            }
        }

        // Automatic Property  --> without Logic

        public string address { set; get; }



    }
}
