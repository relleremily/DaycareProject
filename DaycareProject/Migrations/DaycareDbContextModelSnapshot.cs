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
    partial class DaycareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DaycareProject.Models.BottleFeeding", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Ounce");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.ToTable("BottleFeedings");
                });

            modelBuilder.Entity("DaycareProject.Models.Classroom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassroomName");

                    b.Property<int>("FormID");

                    b.HasKey("ID");

                    b.HasIndex("FormID");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("DaycareProject.Models.FoodAmount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Amount");

                    b.HasKey("ID");

                    b.ToTable("FoodAmounts");
                });

            modelBuilder.Entity("DaycareProject.Models.Form", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("DaycareProject.Models.MealDescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("FoodAmountID");

                    b.Property<int?>("MealDescriptionID");

                    b.Property<int>("MealTimeID");

                    b.Property<string>("Name");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("FoodAmountID");

                    b.HasIndex("MealDescriptionID");

                    b.HasIndex("MealTimeID");

                    b.HasIndex("StudentID");

                    b.ToTable("MealDescriptions");
                });

            modelBuilder.Entity("DaycareProject.Models.MealTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("MealTimes");
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

            modelBuilder.Entity("DaycareProject.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DaycareProject.Models.BottleFeeding", b =>
                {
                    b.HasOne("DaycareProject.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DaycareProject.Models.Classroom", b =>
                {
                    b.HasOne("DaycareProject.Models.Form", "Form")
                        .WithMany()
                        .HasForeignKey("FormID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DaycareProject.Models.MealDescription", b =>
                {
                    b.HasOne("DaycareProject.Models.FoodAmount", "FoodAmount")
                        .WithMany()
                        .HasForeignKey("FoodAmountID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DaycareProject.Models.MealDescription")
                        .WithMany("Meals")
                        .HasForeignKey("MealDescriptionID");

                    b.HasOne("DaycareProject.Models.MealTime", "MealTime")
                        .WithMany()
                        .HasForeignKey("MealTimeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DaycareProject.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
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
