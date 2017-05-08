using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class TablesSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flaps10",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "Flaps15",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "Flaps5",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "OATAbove",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "Flaps10",
                table: "LandingData");

            migrationBuilder.DropColumn(
                name: "Flaps35",
                table: "LandingData");

            migrationBuilder.DropColumn(
                name: "Flaps5",
                table: "LandingData");

            migrationBuilder.AddColumn<bool>(
                name: "above20",
                table: "TakeOffData",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "flaps",
                table: "TakeOffData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "flaps",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "TakeOffData",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Altitude",
                table: "TakeOffData",
                newName: "altitude");

            migrationBuilder.RenameColumn(
                name: "vRef",
                table: "LandingData",
                newName: "vref");

            migrationBuilder.RenameColumn(
                name: "vGa",
                table: "LandingData",
                newName: "vga");

            migrationBuilder.RenameColumn(
                name: "vApp",
                table: "LandingData",
                newName: "vapp");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "LandingData",
                newName: "weight");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "above20",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "flaps",
                table: "TakeOffData");

            migrationBuilder.DropColumn(
                name: "flaps",
                table: "LandingData");

            migrationBuilder.AddColumn<int>(
                name: "Flaps10",
                table: "TakeOffData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Flaps15",
                table: "TakeOffData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Flaps5",
                table: "TakeOffData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OATAbove",
                table: "TakeOffData",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Flaps10",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Flaps35",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Flaps5",
                table: "LandingData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "TakeOffData",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "altitude",
                table: "TakeOffData",
                newName: "Altitude");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "LandingData",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "vref",
                table: "LandingData",
                newName: "vRef");

            migrationBuilder.RenameColumn(
                name: "vga",
                table: "LandingData",
                newName: "vGa");

            migrationBuilder.RenameColumn(
                name: "vapp",
                table: "LandingData",
                newName: "vApp");
        }
    }
}
