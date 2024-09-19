using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pav.Parcial2Rec.Infraestructura.Datos.Migrations
{
    /// <inheritdoc />
    public partial class ModeloInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadComensales = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    OpcionReserva = table.Column<bool>(type: "bit", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mesas_Sectores_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectores",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Sectores",
                columns: new[] { "Id", "Numero" },
                values: new object[,]
                {
                    { new Guid("2c400385-d618-4caa-a3bf-e6f318c83633"), 4 },
                    { new Guid("6d7c9c08-b139-48e4-b25d-521801a02bdb"), 2 },
                    { new Guid("e7ab2920-1e39-46b6-a838-90b9a4f2f30f"), 1 },
                    { new Guid("e8c4d2e3-da49-41c7-a42e-2c0a0c7cec4b"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Mesas",
                columns: new[] { "Id", "CantidadComensales", "Descripcion", "Estado", "Numero", "OpcionReserva", "SectorId" },
                values: new object[,]
                {
                    { new Guid("98a563b2-198c-489f-88d6-3ec80bb1ea35"), 7, "Mesa 2", true, 2, true, new Guid("6d7c9c08-b139-48e4-b25d-521801a02bdb") },
                    { new Guid("b7d25bf9-1e1c-4492-b589-612f54842d61"), 4, "Mesa 1", true, 1, true, new Guid("e7ab2920-1e39-46b6-a838-90b9a4f2f30f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_SectorId",
                table: "Mesas",
                column: "SectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "Sectores");
        }
    }
}
