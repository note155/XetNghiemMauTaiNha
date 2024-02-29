using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duanxetnghiem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KetQua",
                table: "KetQuaXetNghiems",
                newName: "nhommau");

            migrationBuilder.RenameColumn(
                name: "Anhketqua",
                table: "KetQuaXetNghiems",
                newName: "khoa");

            migrationBuilder.CreateTable(
                name: "chisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CSBT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonVi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chisos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GXNandCSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoiXetNghiemId = table.Column<int>(type: "int", nullable: false),
                    ChisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GXNandCSs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GXNandCSs_GoiXetNghiems_GoiXetNghiemId",
                        column: x => x.GoiXetNghiemId,
                        principalTable: "GoiXetNghiems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GXNandCSs_chisos_ChisoId",
                        column: x => x.ChisoId,
                        principalTable: "chisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KQandCSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KetQuaXetNghiemId = table.Column<int>(type: "int", nullable: false),
                    ChisoId = table.Column<int>(type: "int", nullable: false),
                    KetQua = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQandCSs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KQandCSs_KetQuaXetNghiems_KetQuaXetNghiemId",
                        column: x => x.KetQuaXetNghiemId,
                        principalTable: "KetQuaXetNghiems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KQandCSs_chisos_ChisoId",
                        column: x => x.ChisoId,
                        principalTable: "chisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GXNandCSs_ChisoId",
                table: "GXNandCSs",
                column: "ChisoId");

            migrationBuilder.CreateIndex(
                name: "IX_GXNandCSs_GoiXetNghiemId",
                table: "GXNandCSs",
                column: "GoiXetNghiemId");

            migrationBuilder.CreateIndex(
                name: "IX_KQandCSs_ChisoId",
                table: "KQandCSs",
                column: "ChisoId");

            migrationBuilder.CreateIndex(
                name: "IX_KQandCSs_KetQuaXetNghiemId",
                table: "KQandCSs",
                column: "KetQuaXetNghiemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GXNandCSs");

            migrationBuilder.DropTable(
                name: "KQandCSs");

            migrationBuilder.DropTable(
                name: "chisos");

            migrationBuilder.RenameColumn(
                name: "nhommau",
                table: "KetQuaXetNghiems",
                newName: "KetQua");

            migrationBuilder.RenameColumn(
                name: "khoa",
                table: "KetQuaXetNghiems",
                newName: "Anhketqua");
        }
    }
}
