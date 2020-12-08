using Microsoft.EntityFrameworkCore.Migrations;

namespace OshawaMechanic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coustmers",
                columns: table => new
                {
                    coustmerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coustmerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coustmerphoneNumber = table.Column<int>(type: "int", nullable: false),
                    coustmerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coustmers", x => x.coustmerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    employeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employeeId);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    assignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coustmerId = table.Column<int>(type: "int", nullable: false),
                    CoustmerscoustmerId = table.Column<int>(type: "int", nullable: true),
                    employeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeesemployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.assignmentId);
                    table.ForeignKey(
                        name: "FK_Assignments_Coustmers_CoustmerscoustmerId",
                        column: x => x.CoustmerscoustmerId,
                        principalTable: "Coustmers",
                        principalColumn: "coustmerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Employees_EmployeesemployeeId",
                        column: x => x.EmployeesemployeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_CoustmerscoustmerId",
                table: "Assignments",
                column: "CoustmerscoustmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_EmployeesemployeeId",
                table: "Assignments",
                column: "EmployeesemployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Coustmers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
