using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassSubjects",
                columns: table => new
                {
                    ClassSubjectID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubjects", x => x.ClassSubjectID);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "GroupClasses",
                columns: table => new
                {
                    GroupClassID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClasses", x => x.GroupClassID);
                    table.ForeignKey(
                        name: "FK_GroupClasses_Faculties_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculties",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupClassID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Accounts_GroupClasses_GroupClassID",
                        column: x => x.GroupClassID,
                        principalTable: "GroupClasses",
                        principalColumn: "GroupClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    ScoreID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidtermScore = table.Column<double>(type: "float", nullable: false),
                    FinalScore = table.Column<double>(type: "float", nullable: false),
                    AccountID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectID = table.Column<long>(type: "bigint", nullable: false),
                    ClassSubjectID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.ScoreID);
                    table.ForeignKey(
                        name: "FK_Scores_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_ClassSubjects_ClassSubjectID",
                        column: x => x.ClassSubjectID,
                        principalTable: "ClassSubjects",
                        principalColumn: "ClassSubjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClassSubjects",
                columns: new[] { "ClassSubjectID", "ClassName", "SubjectID" },
                values: new object[] { "101", "LTCB01", 1 });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyID", "FacultyName" },
                values: new object[,]
                {
                    { "CNTT", "Công nghệ Thông tin" },
                    { "DTVT", "Điện tử Viễn thông" },
                    { "NNA", "Ngôn ngữ Anh" },
                    { "QTKD", "Quản trị Kinh doanh" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectID", "FacultyID", "SubjectName" },
                values: new object[] { 1L, "CNTT", "Lập trình cơ bản" });

            migrationBuilder.InsertData(
                table: "GroupClasses",
                columns: new[] { "GroupClassID", "FacultyID", "GroupName" },
                values: new object[,]
                {
                    { "0101", "CNTT", "CNTT0101" },
                    { "0102", "CNTT", "CNTT0102" },
                    { "0201", "QTKD", "QTKD0201" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountID", "DateOfBirth", "Gender", "GroupClassID", "Name", "Password" },
                values: new object[,]
                {
                    { "GV010101", new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0101", "Phạm Công Tuấn", "111" },
                    { "SV01010001", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0101", "Nguyễn Quang Hoàng", "111" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreID", "AccountID", "ClassSubjectID", "FinalScore", "MidtermScore", "SubjectID" },
                values: new object[] { 1L, "SV01010001", "101", 8.0, 10.0, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_GroupClassID",
                table: "Accounts",
                column: "GroupClassID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupClasses_FacultyID",
                table: "GroupClasses",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_AccountID",
                table: "Scores",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ClassSubjectID",
                table: "Scores",
                column: "ClassSubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_SubjectID",
                table: "Scores",
                column: "SubjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ClassSubjects");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "GroupClasses");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
