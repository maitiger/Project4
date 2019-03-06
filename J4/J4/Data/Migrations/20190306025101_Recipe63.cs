using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Recipe63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "List",
                table: "Recipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "List",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
