using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    privileges = table.Column<List<string>>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "staff_account",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<int>(type: "integer", nullable: true),
                    first_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    image = table.Column<string>(type: "text", nullable: false),
                    placeholder = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_staff_account", x => x.id);
                    table.ForeignKey(
                        name: "fk_staff_account_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_staff_account_staff_account_created_by",
                        column: x => x.created_by,
                        principalTable: "staff_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_staff_account_staff_account_updated_by",
                        column: x => x.updated_by,
                        principalTable: "staff_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "coupon",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    discount_value = table.Column<decimal>(type: "numeric", nullable: true),
                    discount_type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    times_used = table.Column<decimal>(type: "numeric", nullable: false),
                    max_usage = table.Column<decimal>(type: "numeric", nullable: true),
                    order_amount_limit = table.Column<decimal>(type: "numeric", nullable: true),
                    coupon_start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    coupon_end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coupon", x => x.id);
                    table.ForeignKey(
                        name: "fk_coupon_staff_account_created_by",
                        column: x => x.created_by,
                        principalTable: "staff_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_coupon_staff_account_updated_by",
                        column: x => x.updated_by,
                        principalTable: "staff_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "order_status",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    status_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    color = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    privacy = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_order_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_order_status_staff_account_created_by",
                        column: x => x.created_by,
                        principalTable: "staff_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_order_status_staff_account_updated_by",
                        column: x => x.updated_by,
                        principalTable: "staff_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    coupon_id = table.Column<int>(type: "integer", nullable: true),
                    coupon_id1 = table.Column<Guid>(type: "uuid", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    order_status_id = table.Column<int>(type: "integer", nullable: true),
                    order_status_id1 = table.Column<Guid>(type: "uuid", nullable: false),
                    order_approved_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    order_delivered_carrier_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    order_delivered_customer_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_by = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orders", x => x.id);
                    table.ForeignKey(
                        name: "fk_orders_coupon_coupon_id1",
                        column: x => x.coupon_id1,
                        principalTable: "coupon",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_orders_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_orders_order_status_order_status_id1",
                        column: x => x.order_status_id1,
                        principalTable: "order_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_id = table.Column<int>(type: "integer", nullable: true),
                    order_id = table.Column<int>(type: "integer", nullable: false),
                    order_id1 = table.Column<string>(type: "character varying(50)", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_order_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_order_items_orders_order_id1",
                        column: x => x.order_id1,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_order_items_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_coupon_created_by",
                table: "coupon",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "ix_coupon_updated_by",
                table: "coupon",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_order_id1",
                table: "order_items",
                column: "order_id1");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_product_id",
                table: "order_items",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_status_created_by",
                table: "order_status",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "ix_order_status_updated_by",
                table: "order_status",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "ix_orders_coupon_id1",
                table: "orders",
                column: "coupon_id1");

            migrationBuilder.CreateIndex(
                name: "ix_orders_customer_id",
                table: "orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "ix_orders_order_status_id1",
                table: "orders",
                column: "order_status_id1");

            migrationBuilder.CreateIndex(
                name: "ix_staff_account_created_by",
                table: "staff_account",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "ix_staff_account_role_id",
                table: "staff_account",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_staff_account_updated_by",
                table: "staff_account",
                column: "updated_by");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_items");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "coupon");

            migrationBuilder.DropTable(
                name: "order_status");

            migrationBuilder.DropTable(
                name: "staff_account");

            migrationBuilder.DropTable(
                name: "role");
        }
    }
}
