using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ASP.ET_Core.Migrations
{
    /// <inheritdoc />
    public partial class AddFileandEmployeeClassandchangeIDtoEmployeeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Id");
        }
    }
}
