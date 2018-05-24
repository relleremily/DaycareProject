using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class FormMealTime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormName",
                table: "Forms",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "MealTimeID",
                table: "Forms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MealTime",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTime", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_MealTime_MealTimeID",
                table: "Forms");

            migrationBuilder.DropTable(
                name: "MealTime");

            migrationBuilder.DropIndex(
                name: "IX_Forms_MealTimeID",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "MealTimeID",
                table: "Forms");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Forms",
                newName: "FormName");
        }
    }
}
