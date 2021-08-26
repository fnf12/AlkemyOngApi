using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class userPhotoSeedTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eabe111-745f-40d1-9efd-85a157e7747f", "AQAAAAEAACcQAAAAEBi6Hlj0gwCpVinYTpqrZLPBaZW9KTlwbIvS6IbIiZyDhRQXWTvQ9pkubBMB/OOfBQ==", "c58e74aa-fd67-44f1-b8c3-51d741a4a21c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf7d15d-0ec0-499b-86d4-6befd909ef50", "AQAAAAEAACcQAAAAENNfb1Y9hS21E3PpEOglcxVsciFqZcoyDQ+Gh2AZ2vYw7MmlLFc3G1uZHsT3b7VdWw==", "d3c08fbb-08b1-44a7-8dbd-eabe362c0611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a6ed550-9d77-4739-bec1-1c6f4836b58f", "AQAAAAEAACcQAAAAEJF7vosIbpKOOdtFkwsSEcE2LHwU8wQ6IxLzU+HPyQwIVxK1AeFq7PqjeEQBHYWE6Q==", "23827603-9384-4e4e-8e11-6c0853586793" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88b01be7-2bfa-4e6b-bcb1-1729a9d3841b", "AQAAAAEAACcQAAAAEHR/QSooJrsBrRLgGgcIKCCWkeChfZAP/6J+zI4xTyWcn/k4+Yk/72B4iw53nDG34g==", "3b6c8d8d-de87-428a-94c2-04224a4a3382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8b97bfb-385e-4c77-88d9-fc7945b23e6f", "AQAAAAEAACcQAAAAEMM9QmUOhqsNuDI5qgKVcEXn/RlM5V2pp5uozb8kygGc3FkyQsu4oa+lJEAAnVSf/w==", "b66dd710-609b-4d63-b01f-ac59d278efdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46cfc07c-2c73-4f2e-8af9-4d74d2a39d5e", "AQAAAAEAACcQAAAAELgnerR7JUOhP3yulCZZ1AHOz1djvHzoYF4yw68q7f0wDkz53K2YJYtjXg34CXkZOw==", "b87a234d-e29d-433a-ae14-8b5016ad596e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2640ea5-3301-411c-8a4e-8e72d42d1e01", "AQAAAAEAACcQAAAAEPujRugGpBkTxbqVVAYHmCoc0EOwwlLdmtLEHSj12TnPQHlu1zvS6/bIu6OzvltbmA==", "1d45d241-2047-4fa3-8337-8dadf4a99af9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6828735-7655-4f28-a53b-b55d334a434f", "AQAAAAEAACcQAAAAEAtRTgmku+BCyr5yKl6jnhNhXN5jxGIw4lfnW43NU1trgua2j8Boi7vEFmXYW6eukA==", "ef0d83e3-9db4-487d-a204-cac7a13f478f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afc62b83-ea0c-4fa2-be8a-d166e9ae610a", "AQAAAAEAACcQAAAAEJkH8c+Kp/63ebx4cZn8msO8+h/+KcLk75sDqNmD9eJrDmudVtt5W6rG08LcnemEfw==", "286864b8-c444-48a0-9403-e2eb582250d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f7caa08-cbd0-4cb8-8af8-269eb8c38edd", "AQAAAAEAACcQAAAAEJHLKRmZsXcIHpWDGIK0qTxhAMwgAJpZWQC5rti8Ds1HiVkLmymk+KPiLq98+E330A==", "e2953dbc-b762-47ea-8ae1-7f6569ab4c42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "d796ba7c-a179-41a4-b094-5431fd6fe27e", "AQAAAAEAACcQAAAAEJwXaGgVy+hHMhSmM0SQ0bHdl02obQorALNSN0tpkQNdCSXEfRfczjR0hoOakP1omQ==", "https://placeimg.com/640/480/any", "853f4384-f21f-46ad-a918-459136467bf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "a626cb25-9ee2-42c8-866a-02148c0e42b6", "AQAAAAEAACcQAAAAEGanxyVde7F5vzQdtLdbvntsjoqI3+Li7eWmIHFEUtPmoXVlITAKUhAFd/7Wfa76NA==", "https://placeimg.com/640/480/any", "cd07aa66-1635-4c0d-83f1-23e84e124a84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "4006f09f-99c9-4b5b-96fc-97ff20a6b29c", "AQAAAAEAACcQAAAAEKAW2ajPBikIYAn7J2T1xIEqPHSqeakKEeLijkRdP5+4HMPtEoMZ1YIrAFKfQenyeQ==", "https://placeimg.com/640/480/any", "56294031-051d-4694-97dc-1510f021b265" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "442bcfc4-e63b-4325-a7a2-8f7f9330a791", "AQAAAAEAACcQAAAAEPE7YdOin0Bo6m0XTaS5ovsm5KmdEx2YzNUI9aVlD/f757U3xfWdcQZHX82b3PCjKQ==", "https://placeimg.com/640/480/any", "e1b56087-0e03-4aaf-bdbd-abf791ea7b14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "73901004-3c62-428c-b204-43faaa630582", "AQAAAAEAACcQAAAAEM5gN3Uxbsy2ZqwIIav4Jnfzoih4Lm5TyCfdOiWqb3Va0cfSNQe0xryhxrzFSRVE/A==", "https://placeimg.com/640/480/any", "acd3c7a7-ebac-4ea8-b110-b773903f3335" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "82979cb5-59dd-4b98-a55b-e05eb0f88dfb", "AQAAAAEAACcQAAAAEAllO6cZmhFr9yCXQ7hiHouIBW82lGyHfk8KyEIwATJSEz9rwZXvSVXUf6Js9irSxw==", "https://placeimg.com/640/480/any", "8f58799a-71d3-459d-b27d-27597318b383" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "657673a9-fa76-49cf-b941-e0182673a4c9", "AQAAAAEAACcQAAAAELfDD+JGVWNS6qVa6NKhMUPNVjb82GJ3rLsI3JSbqLIsxMf7y3eWi3z07w7Qnmi3Ng==", "https://placeimg.com/640/480/any", "2921101e-5630-4f62-a1eb-99ab0aa55737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "28a51a00-8854-4d84-8ad2-fffdca1117f5", "AQAAAAEAACcQAAAAEExXgaSKHNkVo44C0Ypbq48W10D8jdMCjtF9vT/R+k007TYQubZHG4dfnP7B25tG3A==", "https://placeimg.com/640/480/any", "8208fa81-0540-442f-8e51-4d219ba35881" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "62defed6-d5aa-4c9b-933d-8c77c32b58bd", "AQAAAAEAACcQAAAAENJ5JoiCAffy/T3cMdP8gyAkyyoj3k4Zwj0kRWNHpZLt0zz8dq17nFUcYqmGHSH2dg==", "https://placeimg.com/640/480/any", "ceff137b-0ed3-409f-a729-5618949635cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "e6978817-f7ee-4aae-b572-aa68878beac0", "AQAAAAEAACcQAAAAEFaLU6KE7AkSNPhbfZqQKK2XvPIgD+59+gngTzYE4FoNtOFyg0H962E+xNqpAZ564g==", "https://placeimg.com/640/480/any", "8e532204-5e2a-4709-9a03-bbef1ef45d12" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 27, 1, 59, 3, 808, DateTimeKind.Local).AddTicks(3080));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 840, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 841, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484310",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afedfc13-45e3-4bed-b347-0a795e8aea5b", "AQAAAAEAACcQAAAAENLAZeWEod4IdWbjalq3NPH89FVsN2YpzNJF5mFl8VyjprNJsLvA4uPsJfUtsj+eOQ==", "2eca57d6-b175-4609-8e74-8b1f241f0fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00679348-8485-4739-af44-b8a5aea8cfc6", "AQAAAAEAACcQAAAAEDuiGMQkfOit11pIvCBUBTNCR1rhszmQir87xET9qKad90SQFQ7xIdncGdzHvGAMsA==", "0cfc5af9-3d03-4ac5-b549-45a393ee7d7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37c0cbbd-f2fc-4a98-8924-c6b04e93dc67", "AQAAAAEAACcQAAAAEBvpuJx99m9bbzSPFQ3FTH7Nxi4cebTpzCP07SQxA4XbFEolMQ/BL/vfqW9PaLQkaw==", "1afc424e-ea8c-433b-9db7-53157dd2229e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b34aa0b-5d36-444a-950c-61e467579960", "AQAAAAEAACcQAAAAEBmrych17BeSILFv5RZtIa8C6JFDkK4byKm0hNSah2Cy9Lw3Vw45pDCnuQPYIocVig==", "bf077cf1-1dc9-4501-b364-fa635547557e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ab94447-d3f7-4ab1-a6c9-65a3ca769edf", "AQAAAAEAACcQAAAAEKmTDDD9ZCMvnRzyMgBnmk4itGIz72imXCFJeePJUJ4PYqr1kZv6RefWFRYrg5SPXQ==", "ef945d5c-ab10-47d1-bc4c-ca869e980fe6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7620f6a1-2187-414d-a32b-146de3b36846", "AQAAAAEAACcQAAAAEBWvmsUxV4xxzi/rHWj2e7u5CdGlkQopWwUHfvRVa0eXyWkTojLLPlXbv70AWVZFTg==", "bd52656f-d578-40fb-a90b-f92a1d6a2d87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5be88f9c-0ad4-4f2a-b64e-beeb2496ed97", "AQAAAAEAACcQAAAAELoR/6aq69Nr29amm0lywLH4rMJi2zWOzqwXZ17MEWVWpjAGXWj0jYHzW+AjOHwStg==", "a094885b-4f8c-4cc0-9a8d-d6e699a8b5fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16cf5fca-367f-4905-abdc-3ccb92ad82c3", "AQAAAAEAACcQAAAAEPzzWLG4K4qs0qtZLZQDFKMBzrQJPQCEuaXBAJRl/TC59UWSkD1DgyP4xastOUUnjg==", "9c61dca3-c052-429a-871e-a9460322e696" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a271584-84c6-4532-a725-d1b94e1babb7", "AQAAAAEAACcQAAAAEDf3cTaIDBFnexgxSqVzzfIhzk9RgYjiW+kY/VCBe4ShYsPrll+zjAuXbMQVoFFmdA==", "e32334da-9d1d-4289-a148-8455e81d64db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f00df5e4-4421-4ec5-a6b4-9c9469ed54b6", "AQAAAAEAACcQAAAAEILmM7JQ9VP9d9khZ3RuN6ZbLjThPpQO+JjxY7U8cKlqJPAIH6nsI3Qi2e89nUIIhg==", "365e3883-c3f0-44f4-a6cb-2ff1505448b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "2f679f39-2e3d-4483-8ff4-e1ff397d1824", "AQAAAAEAACcQAAAAELJMnYeUzSvoCPBniKtlYEwvNylH+SLq+mhUa3S5ge1mykUxkowEDRz+LAoH3EgDYQ==", null, "2eeb9da0-768c-40d7-b788-93c2ae288a5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "0f3491ad-76f6-4498-9c7c-531363164910", "AQAAAAEAACcQAAAAEOttax2XlNk7gVI/FDEd/bC4+LPTtHuxexN58WX5+OrqqTGWXc36bZ9uy7MMNx/5yg==", null, "74069723-ef68-41d4-997c-574c2fa8dffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "05ff992f-6b85-4a09-8f83-328fdc675292", "AQAAAAEAACcQAAAAEK4Uwg/Ivv+rmB7bWwdQTeVKzm3bXBAv3kP7AXV1Albkz4hHzRH9I8Aj0AZIfAKn6g==", null, "76b7f958-f614-4126-b161-596b6ece671f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "c14f113d-ffa9-40a1-8c50-29e5c4d8b88a", "AQAAAAEAACcQAAAAEPfSRHGQfBLba/Ny61992AU7z5IYowKbErE3J2p71xPC+Jl+foA+1wbhW9VXSfgEvw==", null, "674d43d7-a62e-432e-88f9-ce408348c930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "83022dab-c225-4b27-8dd4-2676fbfd6e9b", "AQAAAAEAACcQAAAAEGp58lA20qgTiG6DB/dtHAQbYMBhDaXFem8MQuVxrMWyPd7f/HW3rCGCOveMqYHurA==", null, "8fe98dae-d4fd-467b-bbd3-c8955b222205" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "a486ccad-d8ff-4813-92c9-e7e2278988d7", "AQAAAAEAACcQAAAAEMdrzNItbgiRMuBGnamBGgoRGL1/t/ZT47HtNvesJiDWNhAadGBLeLtC8OiXZiVTRA==", null, "1ef3cf43-6d2a-4f85-a061-7ac18cf76392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "7a359c31-db60-4295-8f94-b48cf5083506", "AQAAAAEAACcQAAAAEBpFAYH3vf/F/ap28x/IKkITuIvjHvWCrAMYWkNQAyjroNysvC7FWenA5ls2906HhQ==", null, "51e693c1-237e-4c35-ad0a-96f293a90a79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "f400cae7-2e6b-4393-83b7-3c9a94e5f829", "AQAAAAEAACcQAAAAEIKHGsF6/OUoiTiJLHuVLlDDFZiuWYTbfBNoU2u/lzO7WGDwqOYoBJumlQtZ6RYnnw==", null, "6baa13b8-6b92-4ff1-800b-2cd378a146b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "9e751298-79fb-45b3-97d9-acab09199765", "AQAAAAEAACcQAAAAEDYeCnAQp5iBM4ZDHQNnt5GBe7u3sdRCyH9k38b3z64vsjwPSMWQM0Ani48VhAtiag==", null, "ed48bae5-5324-40c5-bf35-ae746432db06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "34b00623-2c67-40a6-9852-78429e228247", "AQAAAAEAACcQAAAAEMZrH03EWS3Vi5iiLj4Gk/t96a42yN7hBpwVdOerFdBlmktZBkOu8veQDt/Pj74apw==", null, "80dbb85d-b19b-4695-be6a-e0ea2f659df3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 842, DateTimeKind.Local).AddTicks(8537));
        }
    }
}
