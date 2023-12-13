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
    [Migration("20231118142208_migration5")]
    partial class migration5
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
                        },
                        new
                        {
                            AccountID = "SV01010006",
                            DateOfBirth = new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0101",
                            Name = "Huỳnh Ân",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV01010007",
                            DateOfBirth = new DateTime(2003, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0101",
                            Name = "Nguyễn Lê Anh Chiến",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV01010008",
                            DateOfBirth = new DateTime(2003, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0101",
                            Name = "Đặng Thị Hải Hà",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV01010009",
                            DateOfBirth = new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0101",
                            Name = "Nguyễn Thị Thuý Hà",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV01010010",
                            DateOfBirth = new DateTime(2003, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0101",
                            Name = "Đặng Trung Nghĩa",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV01010011",
                            DateOfBirth = new DateTime(2003, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0101",
                            Name = "Phan Tường Bảo Trâm",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010002",
                            DateOfBirth = new DateTime(2003, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0201",
                            Name = "Thái Ngọc Phương Anh",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010003",
                            DateOfBirth = new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupClassID = "0201",
                            Name = "Phan Anh Đào",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010004",
                            DateOfBirth = new DateTime(2003, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0201",
                            Name = "Trần Hoàng Khánh Ly",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010005",
                            DateOfBirth = new DateTime(2003, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0201",
                            Name = "Trần Thị Xuân Phương",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010006",
                            DateOfBirth = new DateTime(2003, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0201",
                            Name = "Nguyễn Viết Hiệp",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010007",
                            DateOfBirth = new DateTime(2003, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0201",
                            Name = "Đào Duy Vũ",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010008",
                            DateOfBirth = new DateTime(2003, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0201",
                            Name = "Nguyễn Sỹ Hoan",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010009",
                            DateOfBirth = new DateTime(2003, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0201",
                            Name = "Từ Cảnh Minh",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV02010010",
                            DateOfBirth = new DateTime(2003, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0201",
                            Name = "Trần Văn Cường",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010001",
                            DateOfBirth = new DateTime(2003, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0301",
                            Name = "Phạm Quỳnh Anh",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010002",
                            DateOfBirth = new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Nguyễn Ngọc Long",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010003",
                            DateOfBirth = new DateTime(2003, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Đỗ Duy Khánh",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010004",
                            DateOfBirth = new DateTime(2003, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Nhan Gia Khâm",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010005",
                            DateOfBirth = new DateTime(2003, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Trần Hoài Bão",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010006",
                            DateOfBirth = new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0301",
                            Name = "Vũ Ngọc Minh Thu",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010007",
                            DateOfBirth = new DateTime(2003, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Lưu Văn Phúc",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010008",
                            DateOfBirth = new DateTime(2003, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Trần Lê Quốc",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010009",
                            DateOfBirth = new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0301",
                            Name = "Ngô Nguyên Bảo",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV03010010",
                            DateOfBirth = new DateTime(2003, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0301",
                            Name = "Nguyễn Thị Thuý Quỳnh",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010001",
                            DateOfBirth = new DateTime(2003, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Nguyễn Quang Huy",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010002",
                            DateOfBirth = new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            GroupClassID = "0401",
                            Name = "Trần Thị Thanh Nga",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010003",
                            DateOfBirth = new DateTime(2003, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Hồ Ngọc Tiến Hưng",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010004",
                            DateOfBirth = new DateTime(2003, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Phạm Chiến Thắng",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010005",
                            DateOfBirth = new DateTime(2003, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Nguyễn Mai Bảo Huy",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010006",
                            DateOfBirth = new DateTime(2003, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupClassID = "0401",
                            Name = "Nguyễn Mạnh Tiến",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010007",
                            DateOfBirth = new DateTime(2003, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Trần Tuấn Đạt",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010008",
                            DateOfBirth = new DateTime(2003, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Trần Xuân Đức",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010009",
                            DateOfBirth = new DateTime(2003, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Nguyễn Phước Vĩnh",
                            Password = "111"
                        },
                        new
                        {
                            AccountID = "SV04010010",
                            DateOfBirth = new DateTime(2003, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            GroupClassID = "0401",
                            Name = "Nguyễn Văn Lượng",
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
                        },
                        new
                        {
                            GroupClassID = "0301",
                            FacultyID = "NNA",
                            GroupName = "NNA0301"
                        },
                        new
                        {
                            GroupClassID = "0401",
                            FacultyID = "DTVT",
                            GroupName = "DTVT0401"
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