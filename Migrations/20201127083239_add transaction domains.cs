using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedelLibrary.Migrations
{
    public partial class addtransactiondomains : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAsset_Categories_Categoryid",
                table: "LibraryAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryAsset",
                table: "LibraryAsset");

            migrationBuilder.RenameTable(
                name: "LibraryAsset",
                newName: "LibraryAssets");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAsset_Categoryid",
                table: "LibraryAssets",
                newName: "IX_LibraryAssets_Categoryid");

            migrationBuilder.AddColumn<int>(
                name: "LibraryCardId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryAssets",
                table: "LibraryAssets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LibraryCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fees = table.Column<decimal>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckoutHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LibraryAssetId = table.Column<int>(nullable: false),
                    LibraryCardId = table.Column<int>(nullable: false),
                    Checkin = table.Column<DateTime>(nullable: false),
                    Checkout = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LibraryAssetId = table.Column<int>(nullable: false),
                    LibraryCardId = table.Column<int>(nullable: true),
                    Since = table.Column<DateTime>(nullable: false),
                    Untill = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkouts_LibraryCards_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Holds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LibraryAssetId = table.Column<int>(nullable: true),
                    LibraryCardId = table.Column<int>(nullable: true),
                    HoldPlace = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holds_LibraryAssets_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holds_LibraryCards_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LibraryCardId",
                table: "AspNetUsers",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_LibraryAssetId",
                table: "CheckoutHistories",
                column: "LibraryAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_LibraryCardId",
                table: "CheckoutHistories",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_LibraryAssetId",
                table: "Checkouts",
                column: "LibraryAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_LibraryCardId",
                table: "Checkouts",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_LibraryCardId",
                table: "Holds",
                column: "LibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LibraryCards_LibraryCardId",
                table: "AspNetUsers",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_Categories_Categoryid",
                table: "LibraryAssets",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LibraryCards_LibraryCardId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_Categories_Categoryid",
                table: "LibraryAssets");

            migrationBuilder.DropTable(
                name: "CheckoutHistories");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Holds");

            migrationBuilder.DropTable(
                name: "LibraryCards");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LibraryCardId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryAssets",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "LibraryCardId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "LibraryAssets",
                newName: "LibraryAsset");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssets_Categoryid",
                table: "LibraryAsset",
                newName: "IX_LibraryAsset_Categoryid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryAsset",
                table: "LibraryAsset",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAsset_Categories_Categoryid",
                table: "LibraryAsset",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
