using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class DatabaseTableSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandingData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Flaps10 = table.Column<int>(nullable: false),
                    Flaps15 = table.Column<int>(nullable: false),
                    Flaps5 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    vApp = table.Column<int>(nullable: false),
                    vGa = table.Column<int>(nullable: false),
                    vRef = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeOffData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altitude = table.Column<int>(nullable: false),
                    Flaps10 = table.Column<int>(nullable: false),
                    Flaps15 = table.Column<int>(nullable: false),
                    Flaps5 = table.Column<int>(nullable: false),
                    OATAbove = table.Column<bool>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    v2 = table.Column<int>(nullable: false),
                    vr = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeOffData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandingData");

            migrationBuilder.DropTable(
                name: "TakeOffData");
        }
    }
}
