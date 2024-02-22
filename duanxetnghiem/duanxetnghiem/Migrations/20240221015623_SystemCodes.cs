using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duanxetnghiem.Migrations
{
    /// <inheritdoc />
    public partial class SystemCodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TuChois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonXetNghiemId = table.Column<int>(type: "int", nullable: false),
                    Lydo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuChois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuChois_DonXetNghiems_DonXetNghiemId",
                        column: x => x.DonXetNghiemId,
                        principalTable: "DonXetNghiems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TuChois_DonXetNghiemId",
                table: "TuChois",
                column: "DonXetNghiemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TuChois");
        }
    }
}
