using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedelLibrary.Migrations
{
    public partial class AddPersonalDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Middlename",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailsId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(maxLength: 15, nullable: false),
                    Middlename = table.Column<string>(maxLength: 15, nullable: true),
                    Lastname = table.Column<string>(maxLength: 15, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonalDetailsId",
                table: "AspNetUsers",
                column: "PersonalDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonalDetails_PersonalDetailsId",
                table: "AspNetUsers",
                column: "PersonalDetailsId",
                principalTable: "PersonalDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonalDetails_PersonalDetailsId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonalDetailsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonalDetailsId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Middlename",
                table: "AspNetUsers",
                maxLength: 15,
                nullable: true);
        }
    }
}
