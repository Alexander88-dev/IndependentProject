using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrders.Migrations
{
    /// <inheritdoc />
    public partial class MigratioTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_userId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_userId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderTime",
                table: "Orders",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AuthorId",
                table: "Orders",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_AuthorId",
                table: "Orders",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_AuthorId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AuthorId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Orders",
                newName: "OrderTime");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Orders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_userId",
                table: "Orders",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_userId",
                table: "Orders",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
