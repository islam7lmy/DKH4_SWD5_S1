using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipMappingConfigurtationClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MangerId",
                schema: "dbo",
                table: "DepartmentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInfo_MangerId",
                schema: "dbo",
                table: "DepartmentInfo",
                column: "MangerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInfo_Employees_MangerId",
                schema: "dbo",
                table: "DepartmentInfo",
                column: "MangerId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DepartmentInfo_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "DepartmentInfo",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInfo_Employees_MangerId",
                schema: "dbo",
                table: "DepartmentInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DepartmentInfo_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentInfo_MangerId",
                schema: "dbo",
                table: "DepartmentInfo");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MangerId",
                schema: "dbo",
                table: "DepartmentInfo");
        }
    }
}
