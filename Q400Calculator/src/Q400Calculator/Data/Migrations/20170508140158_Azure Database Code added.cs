using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class AzureDatabaseCodeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OAT",
                table: "TakeOffData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OAT",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "above20",
                table: "LandingData",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OAT",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "OAT",
                table: "LandingData");

            migrationBuilder.DropColumn(
                name: "above20",
                table: "LandingData");
        }
    }
}
