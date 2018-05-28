using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class FormAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Classrooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MealDescriptions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MealTimeID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDescriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MealDescriptions_MealTimes_MealTimeID",
                        column: x => x.MealTimeID,
                        principalTable: "MealTimes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealDescriptions_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_FormID",
                table: "Classrooms",
                column: "FormID");

            migrationBuilder.CreateIndex(
                name: "IX_MealDescriptions_MealTimeID",
                table: "MealDescriptions",
                column: "MealTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_MealDescriptions_StudentID",
                table: "MealDescriptions",
                column: "StudentID");

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

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "MealDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_FormID",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Classrooms");
        }
    }
}
