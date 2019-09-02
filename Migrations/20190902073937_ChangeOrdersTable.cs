using Microsoft.EntityFrameworkCore.Migrations;

namespace BIDash.API.Migrations
{
    public partial class ChangeOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderTotal",
                table: "Orders",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Orders",
                newName: "Completed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "OrderTotal");

            migrationBuilder.RenameColumn(
                name: "Completed",
                table: "Orders",
                newName: "Created");
        }
    }
}
