using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class MealDescriptionList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealDescriptionID",
                table: "MealDescriptions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MealDescriptions_MealDescriptionID",
                table: "MealDescriptions",
                column: "MealDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_MealDescriptions_MealDescriptions_MealDescriptionID",
                table: "MealDescriptions",
                column: "MealDescriptionID",
                principalTable: "MealDescriptions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDescriptions_MealDescriptions_MealDescriptionID",
                table: "MealDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_MealDescriptions_MealDescriptionID",
                table: "MealDescriptions");

            migrationBuilder.DropColumn(
                name: "MealDescriptionID",
                table: "MealDescriptions");
        }
    }
}
