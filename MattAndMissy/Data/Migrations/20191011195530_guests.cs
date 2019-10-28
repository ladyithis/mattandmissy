using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MattAndMissy.Data.Migrations
{
    public partial class guests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvitationCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Attending = table.Column<bool>(nullable: true),
                    MealPreference = table.Column<int>(nullable: true),
                    RespondDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
