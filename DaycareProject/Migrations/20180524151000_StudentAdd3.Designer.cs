﻿// <auto-generated />
using DaycareProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DaycareProject.Migrations
{
    [DbContext(typeof(DaycareDbContext))]
    [Migration("20180524151000_StudentAdd3")]
    partial class StudentAdd3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DaycareProject.Models.Classroom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassroomName");

                    b.HasKey("ID");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("DaycareProject.Models.Form", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FormName");

                    b.HasKey("ID");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("DaycareProject.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassroomID");

                    b.Property<string>("StudentFirstName");

                    b.Property<string>("StudentLastName");

                    b.HasKey("ID");

                    b.HasIndex("ClassroomID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DaycareProject.Models.Student", b =>
                {
                    b.HasOne("DaycareProject.Models.Classroom", "Classroom")
                        .WithMany("Students")
                        .HasForeignKey("ClassroomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
