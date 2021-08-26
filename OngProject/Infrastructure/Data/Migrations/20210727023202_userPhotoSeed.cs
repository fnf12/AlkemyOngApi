using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class userPhotoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "afedfc13-45e3-4bed-b347-0a795e8aea5b", "AQAAAAEAACcQAAAAENLAZeWEod4IdWbjalq3NPH89FVsN2YpzNJF5mFl8VyjprNJsLvA4uPsJfUtsj+eOQ==", "https://placeimg.com/640/480/any", "2eca57d6-b175-4609-8e74-8b1f241f0fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "00679348-8485-4739-af44-b8a5aea8cfc6", "AQAAAAEAACcQAAAAEDuiGMQkfOit11pIvCBUBTNCR1rhszmQir87xET9qKad90SQFQ7xIdncGdzHvGAMsA==", "https://placeimg.com/640/480/any", "0cfc5af9-3d03-4ac5-b549-45a393ee7d7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "37c0cbbd-f2fc-4a98-8924-c6b04e93dc67", "AQAAAAEAACcQAAAAEBvpuJx99m9bbzSPFQ3FTH7Nxi4cebTpzCP07SQxA4XbFEolMQ/BL/vfqW9PaLQkaw==", "https://placeimg.com/640/480/any", "1afc424e-ea8c-433b-9db7-53157dd2229e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "5b34aa0b-5d36-444a-950c-61e467579960", "AQAAAAEAACcQAAAAEBmrych17BeSILFv5RZtIa8C6JFDkK4byKm0hNSah2Cy9Lw3Vw45pDCnuQPYIocVig==", "https://placeimg.com/640/480/any", "bf077cf1-1dc9-4501-b364-fa635547557e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "9ab94447-d3f7-4ab1-a6c9-65a3ca769edf", "AQAAAAEAACcQAAAAEKmTDDD9ZCMvnRzyMgBnmk4itGIz72imXCFJeePJUJ4PYqr1kZv6RefWFRYrg5SPXQ==", "https://placeimg.com/640/480/any", "ef945d5c-ab10-47d1-bc4c-ca869e980fe6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "7620f6a1-2187-414d-a32b-146de3b36846", "AQAAAAEAACcQAAAAEBWvmsUxV4xxzi/rHWj2e7u5CdGlkQopWwUHfvRVa0eXyWkTojLLPlXbv70AWVZFTg==", "https://placeimg.com/640/480/any", "bd52656f-d578-40fb-a90b-f92a1d6a2d87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "5be88f9c-0ad4-4f2a-b64e-beeb2496ed97", "AQAAAAEAACcQAAAAELoR/6aq69Nr29amm0lywLH4rMJi2zWOzqwXZ17MEWVWpjAGXWj0jYHzW+AjOHwStg==", "https://placeimg.com/640/480/any", "a094885b-4f8c-4cc0-9a8d-d6e699a8b5fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "16cf5fca-367f-4905-abdc-3ccb92ad82c3", "AQAAAAEAACcQAAAAEPzzWLG4K4qs0qtZLZQDFKMBzrQJPQCEuaXBAJRl/TC59UWSkD1DgyP4xastOUUnjg==", "https://placeimg.com/640/480/any", "9c61dca3-c052-429a-871e-a9460322e696" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "3a271584-84c6-4532-a725-d1b94e1babb7", "AQAAAAEAACcQAAAAEDf3cTaIDBFnexgxSqVzzfIhzk9RgYjiW+kY/VCBe4ShYsPrll+zjAuXbMQVoFFmdA==", "https://placeimg.com/640/480/any", "e32334da-9d1d-4289-a148-8455e81d64db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "f00df5e4-4421-4ec5-a6b4-9c9469ed54b6", "AQAAAAEAACcQAAAAEILmM7JQ9VP9d9khZ3RuN6ZbLjThPpQO+JjxY7U8cKlqJPAIH6nsI3Qi2e89nUIIhg==", "https://placeimg.com/640/480/any", "365e3883-c3f0-44f4-a6cb-2ff1505448b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f679f39-2e3d-4483-8ff4-e1ff397d1824", "AQAAAAEAACcQAAAAELJMnYeUzSvoCPBniKtlYEwvNylH+SLq+mhUa3S5ge1mykUxkowEDRz+LAoH3EgDYQ==", "2eeb9da0-768c-40d7-b788-93c2ae288a5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3491ad-76f6-4498-9c7c-531363164910", "AQAAAAEAACcQAAAAEOttax2XlNk7gVI/FDEd/bC4+LPTtHuxexN58WX5+OrqqTGWXc36bZ9uy7MMNx/5yg==", "74069723-ef68-41d4-997c-574c2fa8dffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ff992f-6b85-4a09-8f83-328fdc675292", "AQAAAAEAACcQAAAAEK4Uwg/Ivv+rmB7bWwdQTeVKzm3bXBAv3kP7AXV1Albkz4hHzRH9I8Aj0AZIfAKn6g==", "76b7f958-f614-4126-b161-596b6ece671f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c14f113d-ffa9-40a1-8c50-29e5c4d8b88a", "AQAAAAEAACcQAAAAEPfSRHGQfBLba/Ny61992AU7z5IYowKbErE3J2p71xPC+Jl+foA+1wbhW9VXSfgEvw==", "674d43d7-a62e-432e-88f9-ce408348c930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83022dab-c225-4b27-8dd4-2676fbfd6e9b", "AQAAAAEAACcQAAAAEGp58lA20qgTiG6DB/dtHAQbYMBhDaXFem8MQuVxrMWyPd7f/HW3rCGCOveMqYHurA==", "8fe98dae-d4fd-467b-bbd3-c8955b222205" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a486ccad-d8ff-4813-92c9-e7e2278988d7", "AQAAAAEAACcQAAAAEMdrzNItbgiRMuBGnamBGgoRGL1/t/ZT47HtNvesJiDWNhAadGBLeLtC8OiXZiVTRA==", "1ef3cf43-6d2a-4f85-a061-7ac18cf76392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a359c31-db60-4295-8f94-b48cf5083506", "AQAAAAEAACcQAAAAEBpFAYH3vf/F/ap28x/IKkITuIvjHvWCrAMYWkNQAyjroNysvC7FWenA5ls2906HhQ==", "51e693c1-237e-4c35-ad0a-96f293a90a79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f400cae7-2e6b-4393-83b7-3c9a94e5f829", "AQAAAAEAACcQAAAAEIKHGsF6/OUoiTiJLHuVLlDDFZiuWYTbfBNoU2u/lzO7WGDwqOYoBJumlQtZ6RYnnw==", "6baa13b8-6b92-4ff1-800b-2cd378a146b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e751298-79fb-45b3-97d9-acab09199765", "AQAAAAEAACcQAAAAEDYeCnAQp5iBM4ZDHQNnt5GBe7u3sdRCyH9k38b3z64vsjwPSMWQM0Ani48VhAtiag==", "ed48bae5-5324-40c5-bf35-ae746432db06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b00623-2c67-40a6-9852-78429e228247", "AQAAAAEAACcQAAAAEMZrH03EWS3Vi5iiLj4Gk/t96a42yN7hBpwVdOerFdBlmktZBkOu8veQDt/Pj74apw==", "80dbb85d-b19b-4695-be6a-e0ea2f659df3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 32, 1, 842, DateTimeKind.Local).AddTicks(8537));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 7, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 8, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484310",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "3449eb6f-ae91-4783-a1d1-47bba82361f1", "AQAAAAEAACcQAAAAEKMrSxwOMOWd8ORWSiBSkO7REn85JmOgEyxHVn+uO2LfV2kuVio3xCBChEJ7k84rcg==", null, "7ffed625-e8c0-408e-805e-270a827f8fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "5f00be1f-92ad-42ac-8590-f894b39d5b1f", "AQAAAAEAACcQAAAAEPykbtRaQhvUXznCFebXksgal/7VjNdEdbu9a8j5POH86OTUcVhg4i/IGxvlpOWvKg==", null, "1e281d04-b3d0-4966-bd0b-4864cd729413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "a6f25a4b-c278-4c21-946f-a53cc01c13d4", "AQAAAAEAACcQAAAAEEXFOaLgXR20udLBHQOqox1urlHHrxwppntXrjCd0yOr7Ge3GI2Q3k76gmJtDAN12A==", null, "014388dd-4fb8-4ba3-8236-5f56f0f71d6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "8a281929-c945-4d18-b09f-efd9359de792", "AQAAAAEAACcQAAAAEGFogPEb0KlZproe4WRJw78yN+Sj0O74d5z1x6ZFg6uIMW1IvVLeHrx30l4U8Y08Gg==", null, "54ccefc8-9501-4fab-ae11-fc0169148304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "da03531f-ce00-4434-abb7-3ebce308d85c", "AQAAAAEAACcQAAAAEFLs5ZC3I0qgoNWNp7dd9PXKnJFlhdBpByRH3+ED6jA+KpkUz8WXlV0upm8IIiTvNg==", null, "f58ae23c-1195-4d10-b5ac-173be38063ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "84b05d38-35b9-4adb-9b53-1a4986eb5d82", "AQAAAAEAACcQAAAAEFSTGkoRrLH9ZNAgD+9xR++U7I5oVHcS8BC3fsuxbb74XG/0f/opCcxsVfijAk/N5A==", null, "e87c1512-4d6a-494e-b8a5-c1b5704e89ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "73ef2c2c-884e-407b-b001-3bad983029fc", "AQAAAAEAACcQAAAAEMCkzqk4XW9ZR+nX85Y124SgshvtSoGOfB/ViUL1xrPhNaMONe+lrkoCpfV+5194+A==", null, "bd86711e-9a89-4464-906a-34f8dceef7d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "3d727324-53c8-43d1-b058-c3e8164b866c", "AQAAAAEAACcQAAAAELKp+zyH9iWpY7r7FFED+eSQLr1Zvxe8mIpcSgULDVz0sjFz+qs43cm7cA7/O7IzQg==", null, "82d7160b-10d1-466d-90f6-6d631ccf4436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "15de83e3-abdb-4ab1-8eb8-0977e2cfc0b6", "AQAAAAEAACcQAAAAEDxkrCy5flTgp8ESADHKbEistFwfA/S9nttGZrZ2GyhAWELa6kg6zk5SQ29mAFN6uA==", null, "f84dae38-e0d8-4450-b6f1-39097ab2abaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Photo", "SecurityStamp" },
                values: new object[] { "cbc2b8af-6bcb-4b6e-8523-4cda4e5899c0", "AQAAAAEAACcQAAAAEHhz6IqCrrlzl33652AKYcYxVadqTq5BxeYT+UDPxJMRnjC3zTU+jVDA2ABdkMjLeQ==", null, "a1850960-ea95-43be-9755-84112f53b497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45c60a50-e887-4f04-84bf-7fc644e52b7b", "AQAAAAEAACcQAAAAEBQdpJuh+fUuHzSnW3jFjOzFkpgD0pkMp1m/6XTOXqqSn7GWaPYzbAvOn2oAliqkmw==", "44f2cb1a-b207-44f3-b1c3-ee83b23dac51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1f2d901-3f12-4ec7-aba9-efd01e4c7867", "AQAAAAEAACcQAAAAEDly9pxEmPxcBl/KqcNN+a5TVu0GlritNE/wD5G4SqE3Muw+hFamGIXbf7IscmZDag==", "642b666c-6ce4-40b2-af23-824ea71fc32e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a989b203-cc27-450a-a89c-acc8944c0523", "AQAAAAEAACcQAAAAEHZvCrIFLcipwXNDXp5e4TmDe0HGVCQ+v8woUg862aVockR/1wyC1KKUJaYjsYO51Q==", "c9fa4c73-b362-47e1-a7b3-b562ddc8bdbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9c136bb-8efe-467a-88ef-b965765373e4", "AQAAAAEAACcQAAAAECvsWCoVP4JoGwuo8tPSCKrT3YfgZwU8Fp8R/fVD/IBalmYhazA+ha89emNE+kr4SQ==", "7be1cb83-a08b-49fb-b74c-93f4b1c37f1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "555a2259-474a-4845-80a5-57fda79f7b7b", "AQAAAAEAACcQAAAAEA89xVPcC9FZJhFbqj4eSOBvxoOIdgxTE/g/nq2ACFpEO7q+2vvh62lpPxnVQbqy3w==", "93114287-2b07-4325-8257-046a21589e76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5249d6e-a672-419b-89fb-6b594611008e", "AQAAAAEAACcQAAAAEKlCEVoUekHoktLmnEQaAsYDhQ1UTQ8Ob60tWqqZrnjcSj20ciY9jcVWXxd/MaomFw==", "b517f630-5f94-49ff-b89a-d04c05f423c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2dc6162-2a35-47e6-b94f-abd156a04dd9", "AQAAAAEAACcQAAAAEL3WGcKG2pdUR8yHI9iltdxsYfFIq7aExKOA+IjFMgNhhGSunlnp4xsS2mO/kbcqbQ==", "f70a27da-34ef-4d54-b451-5cbd94168d25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5e0a81b-00af-4aa4-90e7-52a91b7d2aa6", "AQAAAAEAACcQAAAAEPm3FpFZijVctixbepcJeLMn88b1RdUjDJtbbtHYEf95+PvkxifJ2CMkRqFr3R0mNQ==", "b6b26af5-41b4-47ed-85bd-52d58f0bd949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a9ec68c-cab8-4944-b7ab-11d90d3824ed", "AQAAAAEAACcQAAAAEPnpmPY+E2eF9/KGVYxdixlpMJLycQEvDhfJxDfKf4z8SN+yvur6MWDpvJPOT6W4tw==", "42967a06-bacd-4981-9084-6e03780b8930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67994a98-a8e1-4963-adfd-c1ecd1a02bca", "AQAAAAEAACcQAAAAEG0hucZlFcDo1RJNzau14ZIm5D7Xa/rhhq/DbEFSmXb+wIwGgpAXueLoxtX6dxdJCQ==", "9bf4a993-e37e-4115-b411-f8844d3e13b9" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 6, 27, 9, DateTimeKind.Local).AddTicks(901));
        }
    }
}
