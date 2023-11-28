using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToMeny.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesDB_UsersDB_UserId",
                table: "RolesDB");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesDB_UsersDB_UserId",
                table: "RolesDB",
                column: "UserId",
                principalTable: "UsersDB",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesDB_UsersDB_UserId",
                table: "RolesDB");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesDB_UsersDB_UserId",
                table: "RolesDB",
                column: "UserId",
                principalTable: "UsersDB",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
