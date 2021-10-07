using Microsoft.EntityFrameworkCore.Migrations;

namespace Jdair2.Migrations
{
    public partial class AddFlightsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AModel",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "FuelWeight",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "NumberOfPasseners",
                table: "Aircraft");

            migrationBuilder.RenameColumn(
                name: "TailNumber",
                table: "Aircraft",
                newName: "Max_Fuel_Lbs");

            migrationBuilder.RenameColumn(
                name: "Airline",
                table: "Aircraft",
                newName: "Aircraft_Model");

            migrationBuilder.AddColumn<string>(
                name: "Airline",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlightNumber",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gate_Number",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPasseners",
                table: "Flight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TailNumber",
                table: "Flight",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Airline",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Gate_Number",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "NumberOfPasseners",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "TailNumber",
                table: "Flight");

            migrationBuilder.RenameColumn(
                name: "Max_Fuel_Lbs",
                table: "Aircraft",
                newName: "TailNumber");

            migrationBuilder.RenameColumn(
                name: "Aircraft_Model",
                table: "Aircraft",
                newName: "Airline");

            migrationBuilder.AddColumn<string>(
                name: "AModel",
                table: "Aircraft",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuelWeight",
                table: "Aircraft",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPasseners",
                table: "Aircraft",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
