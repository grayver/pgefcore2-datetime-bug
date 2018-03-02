using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QueryExample.Migrations
{
    public partial class CreateDBStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BasePrice = table.Column<decimal>(nullable: false),
                    BaseSubscriptionDuration = table.Column<TimeSpan>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    IsSubscription = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    ExpiresAt = table.Column<DateTimeOffset>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: true),
                    ShopItemId = table.Column<int>(nullable: true),
                    SubscriptionDuration = table.Column<TimeSpan>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOffers_ShopItem_ShopItemId",
                        column: x => x.ShopItemId,
                        principalTable: "ShopItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopOffers_ShopItemId",
                table: "ShopOffers",
                column: "ShopItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopOffers");

            migrationBuilder.DropTable(
                name: "ShopItem");
        }
    }
}
