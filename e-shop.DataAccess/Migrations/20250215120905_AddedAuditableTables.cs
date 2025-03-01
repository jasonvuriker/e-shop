using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuditableTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "customers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "customer_addresses",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "customer_addresses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "customer_addresses",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "customer_addresses",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "updated_by",
                table: "categories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "categories",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "carts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "carts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "carts",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "carts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "cart_items",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "cart_items",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "cart_items",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "cart_items",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "customer_addresses");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "customer_addresses");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "customer_addresses");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "customer_addresses");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "cart_items");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "cart_items");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "cart_items");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "cart_items");

            migrationBuilder.AlterColumn<int>(
                name: "updated_by",
                table: "categories",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }
    }
}
