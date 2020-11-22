using Microsoft.EntityFrameworkCore.Migrations;

namespace MedelLibrary.Migrations
{
    public partial class addConditionfieldinLibraryAsset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "LibraryAsset",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "LibraryAsset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "LibraryAsset");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "LibraryAsset",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
