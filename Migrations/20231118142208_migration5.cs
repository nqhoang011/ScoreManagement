using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountID", "DateOfBirth", "Gender", "GroupClassID", "Name", "Password" },
                values: new object[,]
                {
                    { "SV01010006", new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0101", "Huỳnh Ân", "111" },
                    { "SV01010007", new DateTime(2003, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0101", "Nguyễn Lê Anh Chiến", "111" },
                    { "SV01010008", new DateTime(2003, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0101", "Đặng Thị Hải Hà", "111" },
                    { "SV01010009", new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0101", "Nguyễn Thị Thuý Hà", "111" },
                    { "SV01010010", new DateTime(2003, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0101", "Đặng Trung Nghĩa", "111" },
                    { "SV01010011", new DateTime(2003, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0101", "Phan Tường Bảo Trâm", "111" },
                    { "SV02010002", new DateTime(2003, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0201", "Thái Ngọc Phương Anh", "111" },
                    { "SV02010003", new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0201", "Phan Anh Đào", "111" },
                    { "SV02010004", new DateTime(2003, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0201", "Trần Hoàng Khánh Ly", "111" },
                    { "SV02010005", new DateTime(2003, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0201", "Trần Thị Xuân Phương", "111" },
                    { "SV02010006", new DateTime(2003, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0201", "Nguyễn Viết Hiệp", "111" },
                    { "SV02010007", new DateTime(2003, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0201", "Đào Duy Vũ", "111" },
                    { "SV02010008", new DateTime(2003, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0201", "Nguyễn Sỹ Hoan", "111" },
                    { "SV02010009", new DateTime(2003, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0201", "Từ Cảnh Minh", "111" },
                    { "SV02010010", new DateTime(2003, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0201", "Trần Văn Cường", "111" }
                });

            migrationBuilder.InsertData(
                table: "GroupClasses",
                columns: new[] { "GroupClassID", "FacultyID", "GroupName" },
                values: new object[,]
                {
                    { "0301", "NNA", "NNA0301" },
                    { "0401", "DTVT", "DTVT0401" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountID", "DateOfBirth", "Gender", "GroupClassID", "Name", "Password" },
                values: new object[,]
                {
                    { "SV03010001", new DateTime(2003, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0301", "Phạm Quỳnh Anh", "111" },
                    { "SV03010002", new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Nguyễn Ngọc Long", "111" },
                    { "SV03010003", new DateTime(2003, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Đỗ Duy Khánh", "111" },
                    { "SV03010004", new DateTime(2003, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Nhan Gia Khâm", "111" },
                    { "SV03010005", new DateTime(2003, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Trần Hoài Bão", "111" },
                    { "SV03010006", new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0301", "Vũ Ngọc Minh Thu", "111" },
                    { "SV03010007", new DateTime(2003, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Lưu Văn Phúc", "111" },
                    { "SV03010008", new DateTime(2003, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Trần Lê Quốc", "111" },
                    { "SV03010009", new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0301", "Ngô Nguyên Bảo", "111" },
                    { "SV03010010", new DateTime(2003, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0301", "Nguyễn Thị Thuý Quỳnh", "111" },
                    { "SV04010001", new DateTime(2003, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Nguyễn Quang Huy", "111" },
                    { "SV04010002", new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0401", "Trần Thị Thanh Nga", "111" },
                    { "SV04010003", new DateTime(2003, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Hồ Ngọc Tiến Hưng", "111" },
                    { "SV04010004", new DateTime(2003, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Phạm Chiến Thắng", "111" },
                    { "SV04010005", new DateTime(2003, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Nguyễn Mai Bảo Huy", "111" },
                    { "SV04010006", new DateTime(2003, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0401", "Nguyễn Mạnh Tiến", "111" },
                    { "SV04010007", new DateTime(2003, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Trần Tuấn Đạt", "111" },
                    { "SV04010008", new DateTime(2003, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Trần Xuân Đức", "111" },
                    { "SV04010009", new DateTime(2003, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Nguyễn Phước Vĩnh", "111" },
                    { "SV04010010", new DateTime(2003, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0401", "Nguyễn Văn Lượng", "111" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV01010006");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV01010007");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV01010008");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV01010009");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV01010010");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV01010011");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010002");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010003");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010004");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010005");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010006");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010007");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010008");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010009");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV02010010");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010001");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010002");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010003");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010004");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010005");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010006");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010007");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010008");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010009");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV03010010");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010001");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010002");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010003");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010004");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010005");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010006");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010007");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010008");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010009");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: "SV04010010");

            migrationBuilder.DeleteData(
                table: "GroupClasses",
                keyColumn: "GroupClassID",
                keyValue: "0301");

            migrationBuilder.DeleteData(
                table: "GroupClasses",
                keyColumn: "GroupClassID",
                keyValue: "0401");
        }
    }
}
