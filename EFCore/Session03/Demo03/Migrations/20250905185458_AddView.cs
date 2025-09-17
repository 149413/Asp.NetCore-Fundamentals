using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"Create Or Alter View DepartmentManagersView
                                        as
                                        Select E.Id as EmpId, E.Name , D.Id as DeptId, D.DeptName
                                        from Employees E , Departments D 
                                        Where E.Dept_Id = D.Id");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View DepartmentManagersView");
        }
    }
}
