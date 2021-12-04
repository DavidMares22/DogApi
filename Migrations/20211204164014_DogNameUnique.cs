using Microsoft.EntityFrameworkCore.Migrations;

namespace DogApi.Migrations
{
    public partial class DogNameUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Dogs_Name",
                table: "Dogs",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dogs_Name",
                table: "Dogs");
        }
    }
}
