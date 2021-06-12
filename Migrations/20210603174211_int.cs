using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbProvAPI2.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<long>(type: "bigint", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paragraph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    HeaderFont = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDataBack = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgBool = table.Column<bool>(type: "bit", nullable: false),
                    ImgWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreatedPages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<bool>(type: "bit", nullable: false),
                    Right = table.Column<bool>(type: "bit", nullable: false),
                    Footer = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FooterString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontMain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgBool = table.Column<bool>(type: "bit", nullable: false),
                    FontHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColorHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderTypeHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDataHeader = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgBoolHeader = table.Column<bool>(type: "bit", nullable: false),
                    FontLeftbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorLeftbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColorLeftbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderTypeLeftbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDataLeftbar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgBoolLeftbar = table.Column<bool>(type: "bit", nullable: false),
                    ColorRightbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColorRightbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderTypeRightbar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDataRightbar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgBoolRightbar = table.Column<bool>(type: "bit", nullable: false),
                    FontFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColorFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderTypeFooter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatedPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    DocData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    LinkString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "CreatedPages");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}
