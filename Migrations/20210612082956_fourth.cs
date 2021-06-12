using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbProvAPI2.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgBool",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgBoolHeader",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgBoolLeftbar",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgBoolRightbar",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgBool",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ImgDataBack",
                table: "Articles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ImgBool",
                table: "CreatedPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImgBoolHeader",
                table: "CreatedPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImgBoolLeftbar",
                table: "CreatedPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImgBoolRightbar",
                table: "CreatedPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImgBool",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgDataBack",
                table: "Articles",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
