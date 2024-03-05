using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duanxetnghiem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NgayTT",
                table: "thanhToans",
                newName: "NgayTT2");

            migrationBuilder.RenameColumn(
                name: "DaTT",
                table: "thanhToans",
                newName: "DaTT2");

            migrationBuilder.AddColumn<long>(
                name: "DaTT1",
                table: "thanhToans",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTT1",
                table: "thanhToans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mota",
                table: "GoiXetNghiems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Anh",
                table: "GoiXetNghiems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaTT1",
                table: "thanhToans");

            migrationBuilder.DropColumn(
                name: "NgayTT1",
                table: "thanhToans");

            migrationBuilder.RenameColumn(
                name: "NgayTT2",
                table: "thanhToans",
                newName: "NgayTT");

            migrationBuilder.RenameColumn(
                name: "DaTT2",
                table: "thanhToans",
                newName: "DaTT");

            migrationBuilder.AlterColumn<string>(
                name: "Mota",
                table: "GoiXetNghiems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Anh",
                table: "GoiXetNghiems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
