﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreManagement;

#nullable disable

namespace ScoreManagement.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20231110183119_migration4")]
    partial class migration4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ScoreManagement.Models.Account", b =>
                {
                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("GroupClassID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.HasIndex("GroupClassID");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountID = "SV01010001",
                            DateOfBirth = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0101",
                            Name = "Nguyễn Quang Hoàng",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "GV010101",
                            DateOfBirth = new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0101",
                            Name = "Phạm Công Tuấn",
                            Password = "111"
                        });
                });

            modelBuilder.Entity("ScoreManagement.Models.ClassSubject", b =>
                {
                    b.Property<string>("ClassSubjectID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ClassSubjectID");

                    b.ToTable("ClassSubjects");

                    b.HasData(
                        new
                        {
                            ClassSubjectID = "101",
                            ClassName = "LTCB01",
                            SubjectID = 1
                        },
                        new
                        {
                            ClassSubjectID = "501",
                            ClassName = "LTW01",
                            SubjectID = 5
                        },
                        new
                        {
                            ClassSubjectID = "502",
                            ClassName = "LTW02",
                            SubjectID = 5
                        },
                        new
                        {
                            ClassSubjectID = "301",
                            ClassName = "QTNL01",
                            SubjectID = 7
                        },
                        new
                        {
                            ClassSubjectID = "401",
                            ClassName = "NPVCP01",
                            SubjectID = 8
                        },
                        new
                        {
                            ClassSubjectID = "601",
                            ClassName = "DTCB01",
                            SubjectID = 6
                        });
                });

            modelBuilder.Entity("ScoreManagement.Models.Faculty", b =>
                {
                    b.Property<string>("FacultyID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            FacultyID = "CNTT",
                            FacultyName = "Công nghệ Thông tin"
                        },
                        new
                        {
                            FacultyID = "QTKD",
                            FacultyName = "Quản trị Kinh doanh"
                        },
                        new
                        {
                            FacultyID = "NNA",
                            FacultyName = "Ngôn ngữ Anh"
                        },
                        new
                        {
                            FacultyID = "DTVT",
                            FacultyName = "Điện tử Viễn thông"
                        });
                });

            modelBuilder.Entity("ScoreManagement.Models.GroupClass", b =>
                {
                    b.Property<string>("GroupClassID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupClassID");

                    b.HasIndex("FacultyID");

                    b.ToTable("GroupClasses");

                    b.HasData(
                        new
                        {
                            GroupClassID = "0101",
                            FacultyID = "CNTT",
                            GroupName = "CNTT0101"
                        },
                        new
                        {
                            GroupClassID = "0102",
                            FacultyID = "CNTT",
                            GroupName = "CNTT0102"
                        },
                        new
                        {
                            GroupClassID = "0201",
                            FacultyID = "QTKD",
                            GroupName = "QTKD0201"
                        });
                });

            modelBuilder.Entity("ScoreManagement.Models.Score", b =>
                {
                    b.Property<long>("ScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ScoreID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassSubjectID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("FinalScore")
                        .HasColumnType("float");

                    b.Property<double>("MidtermScore")
                        .HasColumnType("float");

                    b.Property<long>("SubjectID")
                        .HasColumnType("bigint");

                    b.HasKey("ScoreID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ClassSubjectID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            ScoreID = 1L,
                            AccountID = "SV01010001",
                            ClassSubjectID = "101",
                            FinalScore = 8.0,
                            MidtermScore = 10.0,
                            SubjectID = 1L
                        });
                });

            modelBuilder.Entity("ScoreManagement.Models.Subject", b =>
                {
                    b.Property<long>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SubjectID"));

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectID = 1L,
                            FacultyID = "CNTT",
                            SubjectName = "Lập trình cơ bản"
                        },
                        new
                        {
                            SubjectID = 7L,
                            FacultyID = "QTKD",
                            SubjectName = "Quản trị nhân lực"
                        },
                        new
                        {
                            SubjectID = 8L,
                            FacultyID = "NNA",
                            SubjectName = "Ngữ pháp và cú pháp"
                        },
                        new
                        {
                            SubjectID = 6L,
                            FacultyID = "DTVT",
                            SubjectName = "Điện tử cơ bản"
                        });
                });

            modelBuilder.Entity("ScoreManagement.Models.Account", b =>
                {
                    b.HasOne("ScoreManagement.Models.GroupClass", "GroupClass")
                        .WithMany("Accounts")
                        .HasForeignKey("GroupClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupClass");
                });

            modelBuilder.Entity("ScoreManagement.Models.GroupClass", b =>
                {
                    b.HasOne("ScoreManagement.Models.Faculty", "Faculty")
                        .WithMany("GroupClasses")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("ScoreManagement.Models.Score", b =>
                {
                    b.HasOne("ScoreManagement.Models.Account", "Account")
                        .WithMany("Scores")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoreManagement.Models.ClassSubject", "ClassSubject")
                        .WithMany("Scores")
                        .HasForeignKey("ClassSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoreManagement.Models.Subject", "Subject")
                        .WithMany("Scores")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("ClassSubject");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ScoreManagement.Models.Account", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ScoreManagement.Models.ClassSubject", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ScoreManagement.Models.Faculty", b =>
                {
                    b.Navigation("GroupClasses");
                });

            modelBuilder.Entity("ScoreManagement.Models.GroupClass", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("ScoreManagement.Models.Subject", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
