using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "CRM" },
                    { 2, "IT" },
                    { 3, "Media" },
                    { 4, "Designing" },
                    { 5, "Management" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CreatedDate", "DepartmentId", "EmployementDate", "FirstName", "Gender", "ImagePath", "LastModifiedDate", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 12, 20, 54, 19, 219, DateTimeKind.Local).AddTicks(3540), 1, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(4246), "Ahmad", 0, "Male.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shihab" },
                    { 2, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(8881), 2, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(8906), "Ahmad", 0, "Male.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saquib" },
                    { 3, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9023), 3, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9027), "Ahmad", 0, "Male.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tofayel" },
                    { 4, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9756), 1, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9769), "Ahmad", 0, "Male.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nazrul" },
                    { 5, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9840), 1, new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9844), "Ahmad", 1, "Female.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anika" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
