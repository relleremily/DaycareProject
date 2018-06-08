using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class FoodAmounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmounts_FoodAmounts_FoodAmountID",
                table: "FoodAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmounts_MealDescriptions_MealDescriptionID",
                table: "FoodAmounts");

            migrationBuilder.DropIndex(
                name: "IX_FoodAmounts_FoodAmountID",
                table: "FoodAmounts");

            migrationBuilder.DropIndex(
                name: "IX_FoodAmounts_MealDescriptionID",
                table: "FoodAmounts");

            migrationBuilder.DropColumn(
                name: "FoodAmountID",
                table: "FoodAmounts");

            migrationBuilder.DropColumn(
                name: "MealDescriptionID",
                table: "FoodAmounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodAmountID",
                table: "FoodAmounts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MealDescriptionID",
                table: "FoodAmounts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmounts_FoodAmountID",
                table: "FoodAmounts",
                column: "FoodAmountID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmounts_MealDescriptionID",
                table: "FoodAmounts",
                column: "MealDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmounts_FoodAmounts_FoodAmountID",
                table: "FoodAmounts",
                column: "FoodAmountID",
                principalTable: "FoodAmounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmounts_MealDescriptions_MealDescriptionID",
                table: "FoodAmounts",
                column: "MealDescriptionID",
                principalTable: "MealDescriptions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
