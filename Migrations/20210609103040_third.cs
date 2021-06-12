using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbProvAPI2.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgData",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgDataHeader",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgDataLeftbar",
                table: "CreatedPages");

            migrationBuilder.DropColumn(
                name: "ImgDataRightbar",
                table: "CreatedPages");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PageId",
                table: "Images",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Count",
                table: "CreatedPages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PageId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "CreatedPages");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgData",
                table: "CreatedPages",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgDataHeader",
                table: "CreatedPages",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgDataLeftbar",
                table: "CreatedPages",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgDataRightbar",
                table: "CreatedPages",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
