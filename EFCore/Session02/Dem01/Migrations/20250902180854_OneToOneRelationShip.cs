using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dem01.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmpId",
                table: "Departments",
                column: "EmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmpId",
                table: "Departments",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmpId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmpId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "Departments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
