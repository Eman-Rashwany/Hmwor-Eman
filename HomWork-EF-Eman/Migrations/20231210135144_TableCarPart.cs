using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomWork_EF_Eman.Migrations
{
    /// <inheritdoc />
    public partial class TableCarPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "CARId");

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SapplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarParte",
                columns: table => new
                {
                    PartId = table.Column<int>(type: "int", nullable: false),
                    CARId = table.Column<int>(type: "int", nullable: false),
                    Addedon = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarParte", x => new { x.CARId, x.PartId });
                    table.ForeignKey(
                        name: "FK_CarParte_Cars_CARId",
                        column: x => x.CARId,
                        principalTable: "Cars",
                        principalColumn: "CARId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarParte_Part_PartId",
                        column: x => x.PartId,
                        principalTable: "Part",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarParte_PartId",
                table: "CarParte",
                column: "PartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarParte");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.RenameColumn(
                name: "CARId",
                table: "Cars",
                newName: "Id");
        }
    }
}
