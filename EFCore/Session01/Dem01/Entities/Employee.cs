namespace Dem01.Entities
{

    #region Demo01


    #region EF Core Support 4 Ways For Mapping Classes in DataBase: [Table, View , Function]
    // EF Core Support 4 Ways For Mapping Classes in DataBase: [Table, View , Function]

    //1. By Convention [Default Behaviour]  - Table
    //2. Data Annotation [Set Of Attributes Used for UseData validation]

    // 3. By Flaunt API
    // 4. By Class Configuration 



    // Enitity
    // POCO : Plain OLD CLR Object

    #region Convention
    //internal class Employee  // Table
    //{


    //public int Id { get; set; } // Public Numeric Property Named 'Id' | EmployeeId ---> PK - Indentity(1,1)
    //public string Name { get; set; } // Reference Type : Required [Not Allow Null] - nvarchar(max)
    //public int? Age { get; set; } // Nullable Value Type : int[Age] - Optional [Allow Null] 
    //public double Salary { get; set; } // Value Type : float[Salary] - Required
    //public string? Email { get; set; } // Nullable Reference Type : Optional -  nvarchar(max)
    //public DateTime DateOfCreation { get; set; } // Datetime2 - Required



    //} 
    #endregion


    #region Data Annotation
    //2. Data Annotation

    //[Table("Handasa", Schema = "dbo")]
    //class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)] // To Reject Identity
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(30, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(20, 50)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string? Email { get; set; }  // example.example.com

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string? Phone { get; set; }


    //    [DataType(DataType.DateTime)]
    //    public DateTime DateOfCreation { get; set; }

    //    [Column(TypeName = "money")]  //TypeMoney
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; } // Driven Attribute
    //}

    #endregion


    #region Flaunt API
    //3. Flaunt API

    //class Employee
    //{
    //    public int EmpId { get; set; }
    //    public string Name { get; set; }
    //    public double? Age { get; set; }
    //    public string? Email { get; set; }
    //    public double Salary { get; set; }
    //    public DateTime? DateOfCreation { get; set; }
    #endregion


    #endregion



    #endregion



    #region Demo02


    #region RelationShips

    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double? Age { get; set; }
        public double Salary { get; set; }


        // One To One RelationShip
        // Manage Relationship
        //[InverseProperty(nameof(Department.Manager))]
        public Department? Department { get; set; } // Navigation Property


        //One To Many RelationShip
        // Work RelationShip
        //M ---> 1 

        ////F.K
        public int? WorkForId { get; set; }


        //[InverseProperty(nameof(Department.Employees))]
        public Department? WorkFor { get; set; }



        #endregion

        #endregion









        //public override string ToString()
        //{
        //    return $"{EmpId}  -  {Name}  -  {Age}  -  {Email}  -  {Salary}  -  {DateOfCreation}";
        //}
    }

}
