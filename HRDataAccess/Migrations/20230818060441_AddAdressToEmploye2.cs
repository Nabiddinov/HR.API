using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdressToEmploye2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AdressId",
                table: "Employees",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Adresses_AdressId",
                table: "Employees",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Adresses_AdressId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AdressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Employees");
        }
    }
}
