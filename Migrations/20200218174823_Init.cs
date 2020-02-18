using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bolt.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arucikkek",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nev = table.Column<string>(nullable: true),
                    Darabszam = table.Column<long>(nullable: false),
                    Vonalkod = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arucikkek", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arucikkek");
        }
    }
}
