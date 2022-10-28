using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApplication.Migrations
{
    public partial class BlogImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "blogImage",
                table: "Blog",
                newName: "BlogImage");

            migrationBuilder.AlterColumn<string>(
                name: "BlogImage",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogImage",
                table: "Blog",
                newName: "blogImage");

            migrationBuilder.AlterColumn<byte[]>(
                name: "blogImage",
                table: "Blog",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
