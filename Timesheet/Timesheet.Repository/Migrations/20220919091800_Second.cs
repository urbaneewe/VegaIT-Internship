using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Repository.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "TimesheetByDay",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Timesheet",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<Guid>(
                name: "LeadId",
                table: "Project",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Project",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Employee",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Country",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Client",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Category",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Address",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_LeadId",
                table: "Project",
                column: "LeadId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Lead_LeadId",
                table: "Project",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Lead_LeadId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropIndex(
                name: "IX_Project_LeadId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "TimesheetByDay");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "LeadId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Address");
        }
    }
}
