using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QueryExample.Migrations
{
    public partial class CreateSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO ""ShopItem"" (""Name"", ""BasePrice"", ""IsSubscription"", ""CreatedAt"") VALUES ('Sword', 100, FALSE, CURRENT_TIMESTAMP)");
            migrationBuilder.Sql(@"INSERT INTO ""ShopItem"" (""Name"", ""BasePrice"", ""IsSubscription"", ""CreatedAt"") VALUES ('Axe', 150, FALSE, CURRENT_TIMESTAMP)");
            migrationBuilder.Sql(@"INSERT INTO ""ShopItem"" (""Name"", ""BasePrice"", ""IsSubscription"", ""CreatedAt"") VALUES ('Spell', 200, FALSE, CURRENT_TIMESTAMP)");

            migrationBuilder.Sql(@"INSERT INTO ""ShopOffers"" (""Name"", ""ShopItemId"", ""IsActive"", ""ExpiresAt"", ""CreatedAt"") VALUES ('Offer number one', 1, TRUE, '2018-03-02 16:00:00+03', CURRENT_TIMESTAMP)");
            migrationBuilder.Sql(@"INSERT INTO ""ShopOffers"" (""Name"", ""ShopItemId"", ""IsActive"", ""ExpiresAt"", ""CreatedAt"") VALUES ('Second offer', 2, TRUE, '2018-03-02 18:00:00+03', CURRENT_TIMESTAMP)");
            migrationBuilder.Sql(@"INSERT INTO ""ShopOffers"" (""Name"", ""ShopItemId"", ""IsActive"", ""ExpiresAt"", ""CreatedAt"") VALUES ('Supper offer', 3, TRUE, '2018-03-02 20:00:00+03', CURRENT_TIMESTAMP)");
            migrationBuilder.Sql(@"INSERT INTO ""ShopOffers"" (""Name"", ""ShopItemId"", ""IsActive"", ""ExpiresAt"", ""CreatedAt"") VALUES ('Last chance offer', 1, TRUE, '2018-03-02 22:00:00+03', CURRENT_TIMESTAMP)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
