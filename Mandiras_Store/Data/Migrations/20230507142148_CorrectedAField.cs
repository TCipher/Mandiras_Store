using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mandiras_Store.Data.Migrations
{
    public partial class CorrectedAField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantityStock",
                table: "Products",
                newName: "QuantityInStock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantityInStock",
                table: "Products",
                newName: "QuantityStock");
        }
    }
}
