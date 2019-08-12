using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TCC.Migrations
{
    public partial class dfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Brands",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   CompanyId = table.Column<int>(nullable: false),
                   Name = table.Column<string>(nullable: true),
                   Name_TC = table.Column<string>(nullable: true),
                   Name_SC = table.Column<string>(nullable: true),
                   Description = table.Column<string>(nullable: true),
                   Description_TC = table.Column<string>(nullable: true),
                   Description_SC = table.Column<string>(nullable: true),
                   Url = table.Column<string>(nullable: true),
                   Url_TC = table.Column<string>(nullable: true),
                   Url_SC = table.Column<string>(nullable: true),
                   Logo = table.Column<string>(nullable: true),
                   CoverImage = table.Column<string>(nullable: true),
                   Discoverable = table.Column<bool>(nullable: false),
                   SortingOrder = table.Column<int>(nullable: false),
                   LaunchDate = table.Column<DateTime>(nullable: false),
                   CreationTime = table.Column<DateTime>(nullable: false),
                   UpdationTime = table.Column<DateTime>(nullable: false),
                   DeletionTime = table.Column<DateTime>(nullable: false),
                   TimeZone = table.Column<string>(nullable: true),
                   IsDeleted = table.Column<bool>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Brands", x => x.Id);
               });

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Brands",
                newName: "company_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Brands",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Name_TC",
                table: "Brands",
                newName: "name_tc");

            migrationBuilder.RenameColumn(
                name: "Name_SC",
                table: "Brands",
                newName: "name_sc");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Brands",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Description_TC",
                table: "Brands",
                newName: "description_tc");

            migrationBuilder.RenameColumn(
                name: "Description_SC",
                table: "Brands",
                newName: "description_sc");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Brands",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Url_TC",
                table: "Brands",
                newName: "url_tc");

            migrationBuilder.RenameColumn(
                name: "Url_SC",
                table: "Brands",
                newName: "url_sc");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Brands",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "CoverImage",
                table: "Brands",
                newName: "cover_image");

            migrationBuilder.RenameColumn(
                name: "Discoverable",
                table: "Brands",
                newName: "discoverable");

            migrationBuilder.RenameColumn(
                name: "SortingOrder",
                table: "Brands",
                newName: "sorting_order");

            migrationBuilder.RenameColumn(
                name: "LaunchDate",
                table: "Brands",
                newName: "launch_date");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "Brands",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "UpdationTime",
                table: "Brands",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Brands",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "TimeZone",
                table: "Brands",
                newName: "time_zone");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Brands",
                newName: "is_deleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_brands",
                table: "brands");

            migrationBuilder.RenameTable(
                name: "brands",
                newName: "Brands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "Id");
        }
    }
}
