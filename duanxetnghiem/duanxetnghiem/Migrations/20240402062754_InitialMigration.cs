using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duanxetnghiem.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tuoi",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaysinh",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Quanhe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngaysinh",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Quanhe",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Tuoi",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
