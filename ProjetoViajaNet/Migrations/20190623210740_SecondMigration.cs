using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoViajaNet.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrowserInformation_Items_ItemId",
                table: "BrowserInformation");

            migrationBuilder.DropIndex(
                name: "IX_BrowserInformation_ItemId",
                table: "BrowserInformation");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "BrowserInformation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "BrowserInformation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BrowserInformation_ItemId",
                table: "BrowserInformation",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrowserInformation_Items_ItemId",
                table: "BrowserInformation",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
