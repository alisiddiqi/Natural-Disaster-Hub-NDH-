using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotelyApp.Migrations
{
    public partial class AddPersonToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CityOfResidence = table.Column<string>(nullable: true),
                    LastKnownLocation = table.Column<string>(nullable: true),
                    Search = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonModel");
        }
    }
}
