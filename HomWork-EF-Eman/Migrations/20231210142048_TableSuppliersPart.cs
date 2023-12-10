using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomWork_EF_Eman.Migrations
{
    /// <inheritdoc />
    public partial class TableSuppliersPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarParte_Part_PartId",
                table: "CarParte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Part",
                table: "Part");

            migrationBuilder.RenameTable(
                name: "Part",
                newName: "Parts");

            migrationBuilder.RenameColumn(
                name: "SapplierId",
                table: "Parts",
                newName: "SuppliersId1");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuppliersId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parts_SuppliersId",
                table: "Parts",
                column: "SuppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_SuppliersId1",
                table: "Parts",
                column: "SuppliersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CarParte_Parts_PartId",
                table: "CarParte",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_suppliers_SuppliersId",
                table: "Parts",
                column: "SuppliersId",
                principalTable: "suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_suppliers_SuppliersId1",
                table: "Parts",
                column: "SuppliersId1",
                principalTable: "suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarParte_Parts_PartId",
                table: "CarParte");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_suppliers_SuppliersId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_suppliers_SuppliersId1",
                table: "Parts");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_SuppliersId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_SuppliersId1",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "SuppliersId",
                table: "Parts");

            migrationBuilder.RenameTable(
                name: "Parts",
                newName: "Part");

            migrationBuilder.RenameColumn(
                name: "SuppliersId1",
                table: "Part",
                newName: "SapplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Part",
                table: "Part",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarParte_Part_PartId",
                table: "CarParte",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
