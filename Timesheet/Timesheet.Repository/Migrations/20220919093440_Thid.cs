using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Repository.Migrations
{
    public partial class Thid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Project_LeadId",
                table: "Project");

            migrationBuilder.AddColumn<Guid>(
                name: "LeadId",
                table: "Timesheet",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "HoursPerWeek",
                table: "Lead",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Lead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Lead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Lead",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Lead",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Lead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheet_LeadId",
                table: "Timesheet",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_LeadId",
                table: "Project",
                column: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Lead_LeadId",
                table: "Timesheet",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Lead_LeadId",
                table: "Timesheet");

            migrationBuilder.DropIndex(
                name: "IX_Timesheet_LeadId",
                table: "Timesheet");

            migrationBuilder.DropIndex(
                name: "IX_Project_LeadId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "LeadId",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "HoursPerWeek",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Lead");

            migrationBuilder.CreateIndex(
                name: "IX_Project_LeadId",
                table: "Project",
                column: "LeadId",
                unique: true);
        }
    }
}
