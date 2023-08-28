using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultDataToAdress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                defaultValueSql: "'nabiddinov@gmail.com'",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "AddresLine1", "AddresLine2", "City", "Country", "Postalcode" },
                values: new object[] { 20, "1,Parkent tumani", "2,Boyqozon Qo'rg'on", "Tashkent", "Uzbekistan", "777777" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValueSql: "'nabiddinov@gmail.com'");
        }
    }
}
