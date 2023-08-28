using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddWrongProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WrongProp",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WrongProp",
                table: "Employees");
        }
    }
}
