using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class MealDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Forms_FormID",
                table: "Classrooms");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_FormID",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Classrooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
