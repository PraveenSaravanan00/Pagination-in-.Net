using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaginationWebApi.Migrations
{
    /// <inheritdoc />
    public partial class first6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserDetails",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "UserDetails",
                newName: "userId");
        }
    }
}
