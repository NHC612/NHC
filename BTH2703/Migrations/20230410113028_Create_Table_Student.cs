using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTH2703.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "StudentCode");

            migrationBuilder.RenameColumn(
                name: "PersonAddress",
                table: "Person",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentCode",
                table: "Students",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Person",
                newName: "PersonAddress");
        }
    }
}
