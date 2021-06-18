using Microsoft.EntityFrameworkCore.Migrations;

namespace Furndaqaaqas.Migrations
{
    public partial class Example2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BestProducts",
                newName: "Name2");

            migrationBuilder.AddColumn<string>(
                name: "Name1",
                table: "BestProducts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name1",
                table: "BestProducts");

            migrationBuilder.RenameColumn(
                name: "Name2",
                table: "BestProducts",
                newName: "Name");
        }
    }
}
