using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Recipe3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "List",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "List",
                table: "Recipes");
        }
    }
}
