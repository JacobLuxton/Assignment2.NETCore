using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2Comp2084.Migrations
{
    public partial class FixTableSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_tattooShops_owners_OwnerID",
                table: "tattooShops");

            migrationBuilder.DropColumn(
                name: "TattooShopOwner",
                table: "tattooShops");

            migrationBuilder.DropColumn(
                name: "EmployeeShop",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "bookings");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerID",
                table: "tattooShops",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TattooShopID",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_clients_ClientID",
                table: "bookings",
                column: "ClientID",
                principalTable: "clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_employees_EmployeeID",
                table: "bookings",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_tattooShops_TattooShopID",
                table: "bookings",
                column: "TattooShopID",
                principalTable: "tattooShops",
                principalColumn: "TattooShopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tattooShops_owners_OwnerID",
                table: "tattooShops",
                column: "OwnerID",
                principalTable: "owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_tattooShops_owners_OwnerID",
                table: "tattooShops");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerID",
                table: "tattooShops",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TattooShopOwner",
                table: "tattooShops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeShop",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TattooShopID",
                table: "bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClientName",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "FK_tattooShops_owners_OwnerID",
                table: "tattooShops",
                column: "OwnerID",
                principalTable: "owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
