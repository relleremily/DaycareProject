using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class FoodAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodAmountID",
                table: "MealDescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FoodAmounts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<string>(nullable: true),
                    FoodAmountID = table.Column<int>(nullable: true),
                    MealDescriptionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAmounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodAmounts_FoodAmounts_FoodAmountID",
                        column: x => x.FoodAmountID,
                        principalTable: "FoodAmounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodAmounts_MealDescriptions_MealDescriptionID",
                        column: x => x.MealDescriptionID,
                        principalTable: "MealDescriptions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealDescriptions_FoodAmountID",
                table: "MealDescriptions",
                column: "FoodAmountID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmounts_FoodAmountID",
                table: "FoodAmounts",
                column: "FoodAmountID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmounts_MealDescriptionID",
                table: "FoodAmounts",
                column: "MealDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_MealDescriptions_FoodAmounts_FoodAmountID",
                table: "MealDescriptions",
                column: "FoodAmountID",
                principalTable: "FoodAmounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDescriptions_FoodAmounts_FoodAmountID",
                table: "MealDescriptions");

            migrationBuilder.DropTable(
                name: "FoodAmounts");

            migrationBuilder.DropIndex(
                name: "IX_MealDescriptions_FoodAmountID",
                table: "MealDescriptions");

            migrationBuilder.DropColumn(
                name: "FoodAmountID",
                table: "MealDescriptions");
        }
    }
}
