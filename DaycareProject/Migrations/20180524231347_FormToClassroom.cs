using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class FormToClassroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_MealTime_MealTimeID",
                table: "Forms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTime",
                table: "MealTime");

            migrationBuilder.DropIndex(
                name: "IX_Forms_MealTimeID",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "MealTimeID",
                table: "Forms");

            migrationBuilder.RenameTable(
                name: "MealTime",
                newName: "MealTimes");

            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Classrooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTimes",
                table: "MealTimes",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_FormID",
                table: "Classrooms",
                column: "FormID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Forms_FormID",
                table: "Classrooms",
                column: "FormID",
                principalTable: "Forms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Forms_FormID",
                table: "Classrooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTimes",
                table: "MealTimes");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_FormID",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Classrooms");

            migrationBuilder.RenameTable(
                name: "MealTimes",
                newName: "MealTime");

            migrationBuilder.AddColumn<int>(
                name: "MealTimeID",
                table: "Forms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTime",
                table: "MealTime",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_MealTimeID",
                table: "Forms",
                column: "MealTimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_MealTime_MealTimeID",
                table: "Forms",
                column: "MealTimeID",
                principalTable: "MealTime",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
