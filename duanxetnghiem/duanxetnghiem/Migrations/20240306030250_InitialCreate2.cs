using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duanxetnghiem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonXetNghiemId = table.Column<int>(type: "int", nullable: false),
                    ngaynhanmau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    khoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bacsiid = table.Column<int>(type: "int", nullable: true),
                    phongthuchien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maythuchien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maus_DonXetNghiems_DonXetNghiemId",
                        column: x => x.DonXetNghiemId,
                        principalTable: "DonXetNghiems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maus_DonXetNghiemId",
                table: "Maus",
                column: "DonXetNghiemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maus");
        }
    }
}
