using Microsoft.EntityFrameworkCore.Migrations;

namespace NotelyApp.Migrations
{
    public partial class DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonModel",
                table: "PersonModel");

            migrationBuilder.RenameTable(
                name: "PersonModel",
                newName: "Persons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "PersonModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonModel",
                table: "PersonModel",
                column: "Id");
        }
    }
}
