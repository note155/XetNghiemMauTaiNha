using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duanxetnghiem.Migrations
{
    /// <inheritdoc />
    public partial class SystemCodes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "khoa",
                table: "Maus");

            migrationBuilder.DropColumn(
                name: "maythuchien",
                table: "Maus");

            migrationBuilder.DropColumn(
                name: "phongthuchien",
                table: "Maus");

            migrationBuilder.DropColumn(
                name: "khoa",
                table: "KetQuaXetNghiems");

            migrationBuilder.AddColumn<int>(
                name: "MayxetnghiemId",
                table: "Maus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhongId",
                table: "Maus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "khoaId",
                table: "Maus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "khoaId",
                table: "KetQuaXetNghiems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MayxetnghiemId",
                table: "Maus");

            migrationBuilder.DropColumn(
                name: "PhongId",
                table: "Maus");

            migrationBuilder.DropColumn(
                name: "khoaId",
                table: "Maus");

            migrationBuilder.DropColumn(
                name: "khoaId",
                table: "KetQuaXetNghiems");

            migrationBuilder.AddColumn<string>(
                name: "khoa",
                table: "Maus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maythuchien",
                table: "Maus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phongthuchien",
                table: "Maus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "khoa",
                table: "KetQuaXetNghiems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
