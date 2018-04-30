﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using CoursesApi.Models;
using System;

namespace CoursesApi.Migrations
{
    [DbContext(typeof(CoursesDbContext))]
    partial class CoursesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("CoursesApi.Models.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("CoursesApi.Models.AchievementProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AchievementId");

                    b.Property<int>("Goal");

                    b.Property<int>("Progress");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.HasIndex("UserId");

                    b.ToTable("AchievementProgresses");
                });

            modelBuilder.Entity("CoursesApi.Models.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CourseId");

                    b.Property<int?>("CourseId1");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CourseId1");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("CoursesApi.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CoursesApi.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ChapterId");

                    b.Property<int?>("ChapterId1");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ChapterId1");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("CoursesApi.Models.LessonCompletion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LessonCompletedAt");

                    b.Property<int>("LessonId");

                    b.Property<DateTime>("LessonStartedAt");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.ToTable("LessonCompletions");
                });

            modelBuilder.Entity("CoursesApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoursesApi.Models.AchievementProgress", b =>
                {
                    b.HasOne("CoursesApi.Models.Achievement", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoursesApi.Models.User", "User")
                        .WithMany("AchievementProgresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoursesApi.Models.Chapter", b =>
                {
                    b.HasOne("CoursesApi.Models.Course", "Course")
                        .WithMany("Chapters")
                        .HasForeignKey("CourseId1");
                });

            modelBuilder.Entity("CoursesApi.Models.Lesson", b =>
                {
                    b.HasOne("CoursesApi.Models.Chapter", "Chapter")
                        .WithMany("Lessons")
                        .HasForeignKey("ChapterId1");
                });

            modelBuilder.Entity("CoursesApi.Models.LessonCompletion", b =>
                {
                    b.HasOne("CoursesApi.Models.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoursesApi.Models.User", "User")
                        .WithMany("LessonCompletions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
