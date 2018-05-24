using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class StudentAdd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassroomID",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomID",
                table: "Students",
                column: "ClassroomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classrooms_ClassroomID",
                table: "Students",
                column: "ClassroomID",
                principalTable: "Classrooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classrooms_ClassroomID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassroomID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassroomID",
                table: "Students");
        }
    }
}
