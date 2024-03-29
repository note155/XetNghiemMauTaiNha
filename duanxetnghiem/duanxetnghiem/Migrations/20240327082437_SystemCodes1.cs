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
            migrationBuilder.AddColumn<string>(
                name: "Chuyenkhoa",
                table: "BacSis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sonamkn",
                table: "BacSis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thongtin",
                table: "BacSis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trinhdo",
                table: "BacSis",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chuyenkhoa",
                table: "BacSis");

            migrationBuilder.DropColumn(
                name: "Sonamkn",
                table: "BacSis");

            migrationBuilder.DropColumn(
                name: "Thongtin",
                table: "BacSis");

            migrationBuilder.DropColumn(
                name: "Trinhdo",
                table: "BacSis");
        }
    }
}
