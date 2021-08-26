using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class userseedfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 824, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 826, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484310",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b191b6bc-26e9-4b1e-962f-0d6f26fbc905", "AQAAAAEAACcQAAAAEMX/nXeKR2MHMqzPV3cg1yqzDoE8VPwYrf1qVpiR111tn6jkqCD4lMjmIpiQZJNb1g==", "c1969789-cbc4-42ae-95a2-01b1be81747a", "mail10@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b7c7f226-12b8-4b24-b202-2861dded0323", "AQAAAAEAACcQAAAAENjoQ4rlra2RKs+Y71yekMYYAXRLNGXQdwJJ+8mEQ3Iwk1o01LeTLEOYjcz2rRJTpA==", "498ad946-806e-493b-8b83-081c2c80e142", "mail11@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "97e9976e-7f0a-48cd-8a08-9d1ed91ed53e", "AQAAAAEAACcQAAAAEAGU4qZgdLmh6mihyCPoI2zWorzWwFFfVH09YgsPnpLXvcfMMVD1SAmjyXiqve07dA==", "523b794b-a4de-4f4a-ae19-83cf64a83960", "mail12@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1f691221-01e4-41d7-92e8-86b818afee00", "AQAAAAEAACcQAAAAEPkcRW0Kwo0XVZjY0Ilax0d3yUSunO0ajEHylOgrK59Dp8SHONfChQwoIHzMfqAvRQ==", "9e1856c6-a3ae-4a36-a17e-5c9699d9bf1b", "mail13@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "25403458-bd7c-4217-ac1e-afb990d79791", "AQAAAAEAACcQAAAAEJLRjcvQ040sFz5Jk2DxGdbXGzYwgpLAP50Pn4dxkBrMBT4anf5qOcG2/gmtLbr0Lw==", "8395a18d-9608-410e-9f9b-f1f78378f3a7", "mail14@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e616bb82-a170-4862-ab3f-cfc64e8ad7a2", "AQAAAAEAACcQAAAAEAExvdSGVifh4Jx+ZwY4vVjW4B8O0aiyWmIBIHqhXYU0kw+pXuJyG9Hax2Z+F+JGyg==", "4fb86aa0-224b-429e-a227-e02cbc4e7939", "mail15@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5360bc56-8af4-4b0d-bbd0-313680026001", "AQAAAAEAACcQAAAAEO5UER6xjpu7pWDmWkcosWG0fiOgh4UVdTeS5eCQGILQS3MikhA/azcNgSsbt2wfzA==", "2707088f-01f3-48a3-9bfe-8d113e9d688f", "mail16@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cefe0936-cb56-4b39-832f-e3b19495605e", "AQAAAAEAACcQAAAAEEBN/uu206bWHZtv8NnSo1E9WzKUS6mg0vPZnnXXpjGTT37/q8QTFjxmc/xEOESMCw==", "1398fbc5-8d74-484c-b896-735a71499a65", "mail17@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b048ea80-cb52-409d-9a8b-71f8c5f53af2", "AQAAAAEAACcQAAAAEK27rEMdzLCYmW8plcC5yk6gEdB+OozsE6y9xWr5BEPMilsKxXqt+EPcJx9/VV8q9g==", "7f0bed6f-7f1a-4aa0-844f-c8fec6647bbb", "mail18@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "01eeb18e-fb74-48b7-aee8-e5b1fdb0531c", "AQAAAAEAACcQAAAAEHCeCfwke+ogc8ghmgxi05aIMMoc8LLFvuVD/YfnoMygjQX95cNGX0ymSjQQ2jbCxQ==", "ac452125-c14f-4b17-8acc-7095a6d883a8", "mail19@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bdec1aeb-04a3-4442-a5a4-760d597f9d3c", "AQAAAAEAACcQAAAAEFDmPBewGR1cYdpjYbf1kC8vPxnqixwAzEbtXr/4F3cbsX4/kdtkNScWHrzbV+PU7A==", "904bdc95-d000-4d7c-9880-77eff23ebdd4", "mail30@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cacc1b60-0a08-4f93-a30a-093d60bb7962", "AQAAAAEAACcQAAAAEHr2XakM1+TZeUr0ZSjzYHYg+5V0YQJd8Jl20V3XAcT06w0o78R35M2gqdxQwojWGg==", "1364073c-a2eb-45df-b278-19dd532567d9", "mail31@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9f245120-0afd-4f4f-a581-db3eee52751f", "AQAAAAEAACcQAAAAEAT4PzO7RSujl5pZaaWTa7N/0DPPEtwas80l24eQjnkMmBTs/jZJUpo6HBpulkYZ+Q==", "e963cf2b-10f5-4650-b652-8899bc28ae46", "mail32@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0dfc142d-0ef7-4671-a7fe-53e7c9f5c76b", "AQAAAAEAACcQAAAAEMAQ/8CDq/4CFwoIHGK/LBryYWhMiOtBliDUxtZl9wNVWqJ9I1A+g+hnXLPNDxUzSg==", "a944ade2-6b54-4cf1-a3c1-c4e3bc1ff5cd", "mail33@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "16a901b4-6046-480b-a6ad-4eab896efd96", "AQAAAAEAACcQAAAAEH+E7ZeEHrCAol4BRrJyNtc6Z8AZkgALleUuiSsNInq6Q0xlWh0giLxo1ILiL0SVPA==", "b95bdfd3-304e-4062-b082-55ebd3acc6a6", "mail34@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1b9d115f-8c6c-42d5-8909-aa5da878db56", "AQAAAAEAACcQAAAAEPpk4W8xSPBD9Av0kfjcBKU8PksooUqBX19FtXGrNd6K+aclBTHxi1fmfZjAwg+RoQ==", "cf5d0cb8-c42c-4791-aa24-2a06530a3bd5", "mail35@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5fea78c2-e104-463f-b00b-b89d66ed34f4", "AQAAAAEAACcQAAAAECY/xR60Qu/beg55rPjTlSwGsETGeDXS3qb3vWryhVTyKuK28C8fMp9W0ySQ2iJM5Q==", "76ca1f77-2b61-4fa1-be37-221a5ba509de", "mail36@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b5931fac-9f6e-4df9-af41-015c90847b83", "AQAAAAEAACcQAAAAEB42HEF85SXnqWwrZuzbUolYOlea490fR4A96Hxkffq5Zi5iT/lLIUU5GStcgtSULg==", "ea552341-7fd0-4373-bbb5-ff52bd42f849", "mail37@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4efb88f8-93a1-4f46-b138-a475fdb018ca", "AQAAAAEAACcQAAAAED1MusfcRK318Xd2+4wU8s+4HqdsVulzCGQgqy0pK+ERt2LUUBOdZv5jffC+mMeZpQ==", "85bf65de-6de7-4a1b-9700-aa74c55dd909", "mail38@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c363d853-0b70-412e-acbf-c3d77b2e5759", "AQAAAAEAACcQAAAAEFvC2FTbONew140nMAZtkNQZdN9ymAVGPcTjIhXgEYGmKctYipymBHVWN5/xAsRDAw==", "db3ec1ca-a80c-450d-a52b-af72712c219c", "mail39@mail.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 3, 40, 49, 827, DateTimeKind.Local).AddTicks(5739));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 806, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 807, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484310",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5eabe111-745f-40d1-9efd-85a157e7747f", "AQAAAAEAACcQAAAAEBi6Hlj0gwCpVinYTpqrZLPBaZW9KTlwbIvS6IbIiZyDhRQXWTvQ9pkubBMB/OOfBQ==", "c58e74aa-fd67-44f1-b8c3-51d741a4a21c", "User 10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1bf7d15d-0ec0-499b-86d4-6befd909ef50", "AQAAAAEAACcQAAAAENNfb1Y9hS21E3PpEOglcxVsciFqZcoyDQ+Gh2AZ2vYw7MmlLFc3G1uZHsT3b7VdWw==", "d3c08fbb-08b1-44a7-8dbd-eabe362c0611", "User 11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8a6ed550-9d77-4739-bec1-1c6f4836b58f", "AQAAAAEAACcQAAAAEJF7vosIbpKOOdtFkwsSEcE2LHwU8wQ6IxLzU+HPyQwIVxK1AeFq7PqjeEQBHYWE6Q==", "23827603-9384-4e4e-8e11-6c0853586793", "User 12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "88b01be7-2bfa-4e6b-bcb1-1729a9d3841b", "AQAAAAEAACcQAAAAEHR/QSooJrsBrRLgGgcIKCCWkeChfZAP/6J+zI4xTyWcn/k4+Yk/72B4iw53nDG34g==", "3b6c8d8d-de87-428a-94c2-04224a4a3382", "User 13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a8b97bfb-385e-4c77-88d9-fc7945b23e6f", "AQAAAAEAACcQAAAAEMM9QmUOhqsNuDI5qgKVcEXn/RlM5V2pp5uozb8kygGc3FkyQsu4oa+lJEAAnVSf/w==", "b66dd710-609b-4d63-b01f-ac59d278efdf", "User 14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "46cfc07c-2c73-4f2e-8af9-4d74d2a39d5e", "AQAAAAEAACcQAAAAELgnerR7JUOhP3yulCZZ1AHOz1djvHzoYF4yw68q7f0wDkz53K2YJYtjXg34CXkZOw==", "b87a234d-e29d-433a-ae14-8b5016ad596e", "User 15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f2640ea5-3301-411c-8a4e-8e72d42d1e01", "AQAAAAEAACcQAAAAEPujRugGpBkTxbqVVAYHmCoc0EOwwlLdmtLEHSj12TnPQHlu1zvS6/bIu6OzvltbmA==", "1d45d241-2047-4fa3-8337-8dadf4a99af9", "User 16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e6828735-7655-4f28-a53b-b55d334a434f", "AQAAAAEAACcQAAAAEAtRTgmku+BCyr5yKl6jnhNhXN5jxGIw4lfnW43NU1trgua2j8Boi7vEFmXYW6eukA==", "ef0d83e3-9db4-487d-a204-cac7a13f478f", "User 17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "afc62b83-ea0c-4fa2-be8a-d166e9ae610a", "AQAAAAEAACcQAAAAEJkH8c+Kp/63ebx4cZn8msO8+h/+KcLk75sDqNmD9eJrDmudVtt5W6rG08LcnemEfw==", "286864b8-c444-48a0-9403-e2eb582250d0", "User 18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7f7caa08-cbd0-4cb8-8af8-269eb8c38edd", "AQAAAAEAACcQAAAAEJHLKRmZsXcIHpWDGIK0qTxhAMwgAJpZWQC5rti8Ds1HiVkLmymk+KPiLq98+E330A==", "e2953dbc-b762-47ea-8ae1-7f6569ab4c42", "User 19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d796ba7c-a179-41a4-b094-5431fd6fe27e", "AQAAAAEAACcQAAAAEJwXaGgVy+hHMhSmM0SQ0bHdl02obQorALNSN0tpkQNdCSXEfRfczjR0hoOakP1omQ==", "853f4384-f21f-46ad-a918-459136467bf3", "User 30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a626cb25-9ee2-42c8-866a-02148c0e42b6", "AQAAAAEAACcQAAAAEGanxyVde7F5vzQdtLdbvntsjoqI3+Li7eWmIHFEUtPmoXVlITAKUhAFd/7Wfa76NA==", "cd07aa66-1635-4c0d-83f1-23e84e124a84", "User 31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4006f09f-99c9-4b5b-96fc-97ff20a6b29c", "AQAAAAEAACcQAAAAEKAW2ajPBikIYAn7J2T1xIEqPHSqeakKEeLijkRdP5+4HMPtEoMZ1YIrAFKfQenyeQ==", "56294031-051d-4694-97dc-1510f021b265", "User 32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "442bcfc4-e63b-4325-a7a2-8f7f9330a791", "AQAAAAEAACcQAAAAEPE7YdOin0Bo6m0XTaS5ovsm5KmdEx2YzNUI9aVlD/f757U3xfWdcQZHX82b3PCjKQ==", "e1b56087-0e03-4aaf-bdbd-abf791ea7b14", "User 33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "73901004-3c62-428c-b204-43faaa630582", "AQAAAAEAACcQAAAAEM5gN3Uxbsy2ZqwIIav4Jnfzoih4Lm5TyCfdOiWqb3Va0cfSNQe0xryhxrzFSRVE/A==", "acd3c7a7-ebac-4ea8-b110-b773903f3335", "User 34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "82979cb5-59dd-4b98-a55b-e05eb0f88dfb", "AQAAAAEAACcQAAAAEAllO6cZmhFr9yCXQ7hiHouIBW82lGyHfk8KyEIwATJSEz9rwZXvSVXUf6Js9irSxw==", "8f58799a-71d3-459d-b27d-27597318b383", "User 35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "657673a9-fa76-49cf-b941-e0182673a4c9", "AQAAAAEAACcQAAAAELfDD+JGVWNS6qVa6NKhMUPNVjb82GJ3rLsI3JSbqLIsxMf7y3eWi3z07w7Qnmi3Ng==", "2921101e-5630-4f62-a1eb-99ab0aa55737", "User 36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "28a51a00-8854-4d84-8ad2-fffdca1117f5", "AQAAAAEAACcQAAAAEExXgaSKHNkVo44C0Ypbq48W10D8jdMCjtF9vT/R+k007TYQubZHG4dfnP7B25tG3A==", "8208fa81-0540-442f-8e51-4d219ba35881", "User 37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "62defed6-d5aa-4c9b-933d-8c77c32b58bd", "AQAAAAEAACcQAAAAENJ5JoiCAffy/T3cMdP8gyAkyyoj3k4Zwj0kRWNHpZLt0zz8dq17nFUcYqmGHSH2dg==", "ceff137b-0ed3-409f-a729-5618949635cb", "User 38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e6978817-f7ee-4aae-b572-aa68878beac0", "AQAAAAEAACcQAAAAEFaLU6KE7AkSNPhbfZqQKK2XvPIgD+59+gngTzYE4FoNtOFyg0H962E+xNqpAZ564g==", "8e532204-5e2a-4709-9a03-bbef1ef45d12", "User 39" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 808, DateTimeKind.Local).AddTicks(3080));
        }
    }
}
