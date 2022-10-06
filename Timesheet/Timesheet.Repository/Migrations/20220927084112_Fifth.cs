using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Repository.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Client_Id",
                table: "Address");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Client_Id",
                table: "Address",
                column: "Id",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
