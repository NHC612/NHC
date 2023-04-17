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
                name: "StudentCode",
                table: "Students",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Students",
                newName: "FacultyID");

            migrationBuilder.AddColumn<string>(
                name: "FaculltyID",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_FaculltyID",
                table: "Students",
                column: "FaculltyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Faculty_FaculltyID",
                table: "Students",
                column: "FaculltyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Faculty_FaculltyID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FaculltyID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FaculltyID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "StudentCode");

            migrationBuilder.RenameColumn(
                name: "FacultyID",
                table: "Students",
                newName: "FullName");
        }
    }
}
