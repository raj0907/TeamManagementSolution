using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagement.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessUnit",
                columns: table => new
                {
                    BU_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BU_NAME = table.Column<string>(type: "CHAR(50)", nullable: false),
                    BU_DESCRIPTION = table.Column<string>(type: "CHAR(500)", nullable: false),
                    ACTIVITY = table.Column<bool>(type: "bit", nullable: false),
                    BU_TYPE = table.Column<string>(type: "CHAR(4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnit", x => x.BU_ID);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnitCategories",
                columns: table => new
                {
                    BUC_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BU_ID = table.Column<int>(type: "int", nullable: false),
                    ZURICH_LINE_OF_BUSINESS = table.Column<string>(type: "char(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitCategories", x => x.BUC_ID);
                    table.ForeignKey(
                        name: "FK_BusinessUnitCategories_BusinessUnit_BU_ID",
                        column: x => x.BU_ID,
                        principalTable: "BusinessUnit",
                        principalColumn: "BU_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EMP_LOGIN_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BU_ID = table.Column<int>(type: "int", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "char(50)", nullable: false),
                    LAST_NAME = table.Column<string>(type: "char(50)", nullable: false),
                    STATUS = table.Column<string>(type: "char(3)", nullable: false),
                    EMAIL_ADDRESS = table.Column<string>(type: "char(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EMP_LOGIN_ID);
                    table.ForeignKey(
                        name: "FK_Employee_BusinessUnit_BU_ID",
                        column: x => x.BU_ID,
                        principalTable: "BusinessUnit",
                        principalColumn: "BU_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnitMemebers",
                columns: table => new
                {
                    BUM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BU_ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEE_LOGIN_ID = table.Column<string>(type: "char(100)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IS_MANAGER = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitMemebers", x => x.BUM_ID);
                    table.ForeignKey(
                        name: "FK_BusinessUnitMemebers_BusinessUnit_BU_ID",
                        column: x => x.BU_ID,
                        principalTable: "BusinessUnit",
                        principalColumn: "BU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessUnitMemebers_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EMP_LOGIN_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitCategories_BU_ID",
                table: "BusinessUnitCategories",
                column: "BU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitMemebers_BU_ID",
                table: "BusinessUnitMemebers",
                column: "BU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitMemebers_EmployeeId",
                table: "BusinessUnitMemebers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BU_ID",
                table: "Employee",
                column: "BU_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessUnitCategories");

            migrationBuilder.DropTable(
                name: "BusinessUnitMemebers");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "BusinessUnit");
        }
    }
}
