﻿// <auto-generated />
using Faculty.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Faculty.Migrations.SubmissionDb
{
    [DbContext(typeof(SubmissionDbContext))]
    partial class SubmissionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Faculty.Models.Submission", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssignmentID");

                    b.Property<string>("DateTime");

                    b.Property<string>("SubmissionLink");

                    b.HasKey("ID");

                    b.ToTable("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
