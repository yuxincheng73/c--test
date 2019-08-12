using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCC.Migrations
{
    public partial class BrandsSQLversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Brands",
                newName: "logo");

            migrationBuilder.AddColumn<int>(
                name: "company_id",
                table: "Brands",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Brands",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "Brands",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "description_sc",
                table: "Brands",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description_tc",
                table: "Brands",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name_sc",
                table: "Brands",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name_tc",
                table: "Brands",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "Brands",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "url_sc",
                table: "Brands",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url_tc",
                table: "Brands",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "company_id",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "description_sc",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "description_tc",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "name_sc",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "name_tc",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "url_sc",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "url_tc",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Brands",
                newName: "Logo");
        }
    }
}
