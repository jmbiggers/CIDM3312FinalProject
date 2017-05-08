using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class FixedValueinLandingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flaps15",
                table: "LandingData");

            migrationBuilder.AddColumn<int>(
                name: "Flaps35",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flaps35",
                table: "LandingData");

            migrationBuilder.AddColumn<int>(
                name: "Flaps15",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);
        }
    }
}
