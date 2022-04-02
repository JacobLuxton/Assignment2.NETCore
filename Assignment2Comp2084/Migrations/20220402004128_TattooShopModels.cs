using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2Comp2084.Migrations
{
    public partial class TattooShopModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "varchar(50)", nullable: false),
                    ClientAge = table.Column<int>(type: "int", nullable: false),
                    ClientPhoneNumber = table.Column<string>(type: "varchar(50)", nullable: false),
                    ClientGender = table.Column<string>(type: "varchar(20)", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_clients_bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "bookings",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "varchar(50)", nullable: false),
                    EmployeeAge = table.Column<int>(type: "int", nullable: false),
                    TattooSpecialty = table.Column<string>(type: "varchar(50)", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_employees_bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "bookings",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tattooShops",
                columns: table => new
                {
                    TattooShopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TattooShopName = table.Column<string>(type: "varchar(50)", nullable: false),
                    TattooShopLocation = table.Column<string>(type: "varchar(50)", nullable: false),
                    TattooShopNumber = table.Column<string>(type: "varchar(50)", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tattooShops", x => x.TattooShopID);
                    table.ForeignKey(
                        name: "FK_tattooShops_bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "bookings",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tattooShops_employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "owners",
                columns: table => new
                {
                    OwnerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName = table.Column<string>(type: "varchar(50)", nullable: false),
                    OwnerAge = table.Column<int>(type: "int", nullable: false),
                    OwnerAdress = table.Column<string>(type: "varchar(50)", nullable: false),
                    OwnerPhoneNumber = table.Column<string>(type: "varchar(50)", nullable: false),
                    TattooShopID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owners", x => x.OwnerID);
                    table.ForeignKey(
                        name: "FK_owners_tattooShops_TattooShopID",
                        column: x => x.TattooShopID,
                        principalTable: "tattooShops",
                        principalColumn: "TattooShopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clients_BookingID",
                table: "clients",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_BookingID",
                table: "employees",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_owners_TattooShopID",
                table: "owners",
                column: "TattooShopID");

            migrationBuilder.CreateIndex(
                name: "IX_tattooShops_BookingID",
                table: "tattooShops",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_tattooShops_EmployeeID",
                table: "tattooShops",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "owners");

            migrationBuilder.DropTable(
                name: "tattooShops");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "bookings");
        }
    }
}
