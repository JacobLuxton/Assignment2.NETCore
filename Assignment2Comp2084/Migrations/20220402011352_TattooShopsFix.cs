using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2Comp2084.Migrations
{
    public partial class TattooShopsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clients_bookings_BookingID",
                table: "clients");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_bookings_BookingID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_owners_tattooShops_TattooShopID",
                table: "owners");

            migrationBuilder.DropForeignKey(
                name: "FK_tattooShops_bookings_BookingID",
                table: "tattooShops");

            migrationBuilder.DropForeignKey(
                name: "FK_tattooShops_employees_EmployeeID",
                table: "tattooShops");

            migrationBuilder.DropIndex(
                name: "IX_tattooShops_BookingID",
                table: "tattooShops");

            migrationBuilder.DropIndex(
                name: "IX_owners_TattooShopID",
                table: "owners");

            migrationBuilder.DropIndex(
                name: "IX_employees_BookingID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_clients_BookingID",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "TattooShopID",
                table: "owners");

            migrationBuilder.DropColumn(
                name: "BookingID",
                table: "clients");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "tattooShops",
                newName: "OwnerID");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "tattooShops",
                newName: "TattooShopOwner");

            migrationBuilder.RenameIndex(
                name: "IX_tattooShops_EmployeeID",
                table: "tattooShops",
                newName: "IX_tattooShops_OwnerID");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "employees",
                newName: "EmployeeShop");

            migrationBuilder.RenameColumn(
                name: "BookingDate",
                table: "bookings",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "TattooShopID",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientName",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeName",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShopName",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TattooShopID",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_TattooShopID",
                table: "employees",
                column: "TattooShopID");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_ClientID",
                table: "bookings",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_EmployeeID",
                table: "bookings",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_TattooShopID",
                table: "bookings",
                column: "TattooShopID");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_clients_ClientID",
                table: "bookings",
                column: "ClientID",
                principalTable: "clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_employees_EmployeeID",
                table: "bookings",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_tattooShops_TattooShopID",
                table: "bookings",
                column: "TattooShopID",
                principalTable: "tattooShops",
                principalColumn: "TattooShopID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_tattooShops_TattooShopID",
                table: "employees",
                column: "TattooShopID",
                principalTable: "tattooShops",
                principalColumn: "TattooShopID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tattooShops_owners_OwnerID",
                table: "tattooShops",
                column: "OwnerID",
                principalTable: "owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_clients_ClientID",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_employees_EmployeeID",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_tattooShops_TattooShopID",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_tattooShops_TattooShopID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_tattooShops_owners_OwnerID",
                table: "tattooShops");

            migrationBuilder.DropIndex(
                name: "IX_employees_TattooShopID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_bookings_ClientID",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_EmployeeID",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_TattooShopID",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "TattooShopID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "TattooShopID",
                table: "bookings");

            migrationBuilder.RenameColumn(
                name: "TattooShopOwner",
                table: "tattooShops",
                newName: "BookingID");

            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "tattooShops",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_tattooShops_OwnerID",
                table: "tattooShops",
                newName: "IX_tattooShops_EmployeeID");

            migrationBuilder.RenameColumn(
                name: "EmployeeShop",
                table: "employees",
                newName: "BookingID");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "bookings",
                newName: "BookingDate");

            migrationBuilder.AddColumn<int>(
                name: "TattooShopID",
                table: "owners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookingID",
                table: "clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tattooShops_BookingID",
                table: "tattooShops",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_owners_TattooShopID",
                table: "owners",
                column: "TattooShopID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_BookingID",
                table: "employees",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_clients_BookingID",
                table: "clients",
                column: "BookingID");

            migrationBuilder.AddForeignKey(
                name: "FK_clients_bookings_BookingID",
                table: "clients",
                column: "BookingID",
                principalTable: "bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_bookings_BookingID",
                table: "employees",
                column: "BookingID",
                principalTable: "bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_owners_tattooShops_TattooShopID",
                table: "owners",
                column: "TattooShopID",
                principalTable: "tattooShops",
                principalColumn: "TattooShopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tattooShops_bookings_BookingID",
                table: "tattooShops",
                column: "BookingID",
                principalTable: "bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tattooShops_employees_EmployeeID",
                table: "tattooShops",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
