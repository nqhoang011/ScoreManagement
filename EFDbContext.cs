using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ScoreManagement
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassSubject> ClassSubjects { get; set; }
        public DbSet<GroupClass> GroupClasses { get; set; }
        public void ConfigureServices(IServiceCollection services)
             => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>().HasData(
            new Faculty
            {
                FacultyID = "CNTT",
                FacultyName = "Công nghệ Thông tin"
            },
            new Faculty
            {
                FacultyID = "QTKD",
                FacultyName = "Quản trị Kinh doanh"
            },
            new Faculty
            {
                FacultyID = "NNA",
                FacultyName = "Ngôn ngữ Anh"
            },
            new Faculty
            {
                FacultyID = "DTVT",
                FacultyName = "Điện tử Viễn thông"
            });
            modelBuilder.Entity<Account>().HasData(
            new Account
            {
                AccountID = "SV01010001",
                Password = "111",
                Name = "Nguyễn Quang Hoàng",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-01-01"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "GV010101",
                Password = "111",
                Name = "Phạm Công Tuấn",
                Gender = true,
                DateOfBirth = DateTime.Parse("1983-01-01"),
                GroupClassID = "0101"
            });
            modelBuilder.Entity<Account>().HasData(
            new Account
            {
                AccountID = "SV01010006",
                Password = "111",
                Name = "Huỳnh Ân",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-06-10"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "SV01010007",
                Password = "111",
                Name = "Nguyễn Lê Anh Chiến",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-11-10"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "SV01010008",
                Password = "111",
                Name = "Đặng Thị Hải Hà",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-06-03"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "SV01010009",
                Password = "111",
                Name = "Nguyễn Thị Thuý Hà",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-10-10"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "SV01010010",
                Password = "111",
                Name = "Đặng Trung Nghĩa",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-01-05"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "SV01010011",
                Password = "111",
                Name = "Phan Tường Bảo Trâm",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-12-16"),
                GroupClassID = "0101"
            },
            new Account
            {
                AccountID = "SV02010002",
                Password = "111",
                Name = "Thái Ngọc Phương Anh",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-12-10"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010003",
                Password = "111",
                Name = "Phan Anh Đào",
                Gender = null,
                DateOfBirth = DateTime.Parse("2003-06-10"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010004",
                Password = "111",
                Name = "Trần Hoàng Khánh Ly",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-12-21"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010005",
                Password = "111",
                Name = "Trần Thị Xuân Phương",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-08-10"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010006",
                Password = "111",
                Name = "Nguyễn Viết Hiệp",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-06-23"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010007",
                Password = "111",
                Name = "Đào Duy Vũ",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-09-12"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010008",
                Password = "111",
                Name = "Nguyễn Sỹ Hoan",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-04-23"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010009",
                Password = "111",
                Name = "Từ Cảnh Minh",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-04-20"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV02010010",
                Password = "111",
                Name = "Trần Văn Cường",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-12-16"),
                GroupClassID = "0201"
            },
            new Account
            {
                AccountID = "SV03010001",
                Password = "111",
                Name = "Phạm Quỳnh Anh",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-01-23"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010002",
                Password = "111",
                Name = "Nguyễn Ngọc Long",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-02-15"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010003",
                Password = "111",
                Name = "Đỗ Duy Khánh",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-01-15"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010004",
                Password = "111",
                Name = "Nhan Gia Khâm",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-01-09"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010005",
                Password = "111",
                Name = "Trần Hoài Bão",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-03-12"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010006",
                Password = "111",
                Name = "Vũ Ngọc Minh Thu",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-07-22"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010007",
                Password = "111",
                Name = "Lưu Văn Phúc",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-05-12"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010008",
                Password = "111",
                Name = "Trần Lê Quốc",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-02-22"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010009",
                Password = "111",
                Name = "Ngô Nguyên Bảo",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-09-11"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV03010010",
                Password = "111",
                Name = "Nguyễn Thị Thuý Quỳnh",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-09-12"),
                GroupClassID = "0301"
            },
            new Account
            {
                AccountID = "SV04010001",
                Password = "111",
                Name = "Nguyễn Quang Huy",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-09-20"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010002",
                Password = "111",
                Name = "Trần Thị Thanh Nga",
                Gender = false,
                DateOfBirth = DateTime.Parse("2003-11-23"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010003",
                Password = "111",
                Name = "Hồ Ngọc Tiến Hưng",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-09-22"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010004",
                Password = "111",
                Name = "Phạm Chiến Thắng",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-10-11"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010005",
                Password = "111",
                Name = "Nguyễn Mai Bảo Huy",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-11-04"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010006",
                Password = "111",
                Name = "Nguyễn Mạnh Tiến",
                Gender = null,
                DateOfBirth = DateTime.Parse("2003-03-11"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010007",
                Password = "111",
                Name = "Trần Tuấn Đạt",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-08-11"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010008",
                Password = "111",
                Name = "Trần Xuân Đức",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-11-20"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010009",
                Password = "111",
                Name = "Nguyễn Phước Vĩnh",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-01-12"),
                GroupClassID = "0401"
            },
            new Account
            {
                AccountID = "SV04010010",
                Password = "111",
                Name = "Nguyễn Văn Lượng",
                Gender = true,
                DateOfBirth = DateTime.Parse("2003-12-12"),
                GroupClassID = "0401"
            });
            modelBuilder.Entity<Subject>().HasData(
            new Subject
            {
                SubjectID = 1,
                SubjectName = "Lập trình cơ bản",
                FacultyID = "CNTT"
            },
            new Subject
            {
                SubjectID = 7,
                SubjectName = "Quản trị nhân lực",
                FacultyID = "QTKD"
            },
            new Subject
            {
                SubjectID = 8,
                SubjectName = "Ngữ pháp và cú pháp",
                FacultyID = "NNA"
            },
            new Subject
            {
                SubjectID = 6,
                SubjectName = "Điện tử cơ bản",
                FacultyID = "DTVT"
            });
            modelBuilder.Entity<ClassSubject>().HasData(
            new ClassSubject
            {
                ClassSubjectID = "101",
                ClassName = "LTCB01",
                SubjectID = 1
            });
            modelBuilder.Entity<ClassSubject>().HasData(new ClassSubject
            {
                ClassSubjectID = "501",
                ClassName = "LTW01",
                SubjectID = 5
            });
            modelBuilder.Entity<ClassSubject>().HasData(new ClassSubject
            {
                ClassSubjectID = "502",
                ClassName = "LTW02",
                SubjectID = 5
            });
            modelBuilder.Entity<ClassSubject>().HasData(new ClassSubject
            {
                ClassSubjectID = "301",
                ClassName = "QTNL01",
                SubjectID = 7
            },
            new ClassSubject
            {
                ClassSubjectID = "401",
                ClassName = "NPVCP01",
                SubjectID = 8
            },
            new ClassSubject
            {
                ClassSubjectID = "601",
                ClassName = "DTCB01",
                SubjectID = 6
            });
            modelBuilder.Entity<Score>().HasData(
            new Score
            {
                ScoreID = 1,
                AccountID = "SV01010001",
                SubjectID = 1,
                ClassSubjectID = "101",
                MidtermScore = 10,
                FinalScore = 8,
            });
            modelBuilder.Entity<GroupClass>().HasData(
            new GroupClass
            {
                GroupClassID = "0101",
                GroupName = "CNTT0101",
                FacultyID = "CNTT"
            },
            new GroupClass
            {
                GroupClassID = "0102",
                GroupName = "CNTT0102",
                FacultyID = "CNTT",
            },
            new GroupClass
            {
                GroupClassID = "0201",
                GroupName = "QTKD0201",
                FacultyID = "QTKD"
            });
            modelBuilder.Entity<GroupClass>().HasData(
            new GroupClass
            {
                GroupClassID = "0301",
                GroupName = "NNA0301",
                FacultyID = "NNA"
            },
            new GroupClass
            {
                GroupClassID = "0401",
                GroupName = "DTVT0401",
                FacultyID = "DTVT"
            });
        }
    }
}
