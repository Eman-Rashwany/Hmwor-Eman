using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomWork_EF_Eman.Migrations
{
    /// <inheritdoc />
    public partial class TablesupPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_suppliers_SuppliersId1",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_SuppliersId1",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "SuppliersId1",
                table: "Parts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuppliersId1",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_SuppliersId1",
                table: "Parts",
                column: "SuppliersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_suppliers_SuppliersId1",
                table: "Parts",
                column: "SuppliersId1",
                principalTable: "suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
