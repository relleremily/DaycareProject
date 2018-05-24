using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DaycareProject.Migrations
{
    public partial class StudentAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "StudentLastName");

            migrationBuilder.AddColumn<string>(
                name: "StudentFirstName",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentFirstName",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentLastName",
                table: "Students",
                newName: "StudentName");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomID",
                table: "Students",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
