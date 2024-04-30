using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySalon.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costumer",
                columns: table => new
                {
                    cod_serial_costumer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costumer", x => x.cod_serial_costumer);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    cod_serial_reserve = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_clienteid = table.Column<int>(type: "int", nullable: false),
                    checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantify_itens = table.Column<int>(type: "int", nullable: false),
                    cod_costurmer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.cod_serial_reserve);
                    table.ForeignKey(
                        name: "FK_Reserves_costumer_cod_costurmer",
                        column: x => x.cod_costurmer,
                        principalTable: "costumer",
                        principalColumn: "cod_serial_costumer");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserves_cod_costurmer",
                table: "Reserves",
                column: "cod_costurmer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "costumer");
        }
    }
}
