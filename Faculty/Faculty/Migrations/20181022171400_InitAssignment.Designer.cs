﻿// <auto-generated />
using Faculty.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Faculty.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    [Migration("20181022171400_InitAssignment")]
    partial class InitAssignment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Faculty.Models.Assignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignmentDescription");

                    b.Property<string>("AssignmentTitle");

                    b.Property<string>("AttachmentFulLink");

                    b.Property<int>("CourseID");

                    b.Property<string>("CourseName");

                    b.Property<int>("DeadLineMonth");

                    b.Property<int>("DeadlineDay");

                    b.Property<string>("DeadlineTime");

                    b.Property<int>("DeadlineYear");

                    b.Property<string>("SubmissionDirectoryLink");

                    b.HasKey("ID");

                    b.ToTable("Assignments");
                });
#pragma warning restore 612, 618
        }
    }
}
