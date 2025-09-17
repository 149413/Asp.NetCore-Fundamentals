namespace Dem01.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }



        // One To One

        // Note : 
        //In Convention
        // - The CLR : Create By Default ForeignKey Named [ManagerId / EmployeeId]
        // - Will Create In Department To Provide Null

        // Create  FK Manually 

        //[ForeignKey("Manager")] // By String
        //[ForeignKey(nameof(Manager))] // By Anomynous Type
        public int EmpId { get; set; }  // With diffirent Name

        public Employee Manager { get; set; } // Navigation Property


        //One To Many RelationShip
        // Work RelationShip
        //1 ---> M  

        public List<Employee> Employees { get; set; }  // Navigation Property



        #region Note
        // Note: The Best Practise for Implemeent Relationships is
        // - Flaunt API
        // - Class Configuration

        #endregion



    }
}
