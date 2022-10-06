using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Repository.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Client_AddressId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AddressId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressId",
                table: "Client",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_AddressId",
                table: "Client");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressId",
                table: "Address",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Client_AddressId",
                table: "Address",
                column: "AddressId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
