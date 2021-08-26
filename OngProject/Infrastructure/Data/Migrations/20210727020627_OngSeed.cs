using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class OngSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3449eb6f-ae91-4783-a1d1-47bba82361f1", "AQAAAAEAACcQAAAAEKMrSxwOMOWd8ORWSiBSkO7REn85JmOgEyxHVn+uO2LfV2kuVio3xCBChEJ7k84rcg==", "7ffed625-e8c0-408e-805e-270a827f8fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f00be1f-92ad-42ac-8590-f894b39d5b1f", "AQAAAAEAACcQAAAAEPykbtRaQhvUXznCFebXksgal/7VjNdEdbu9a8j5POH86OTUcVhg4i/IGxvlpOWvKg==", "1e281d04-b3d0-4966-bd0b-4864cd729413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6f25a4b-c278-4c21-946f-a53cc01c13d4", "AQAAAAEAACcQAAAAEEXFOaLgXR20udLBHQOqox1urlHHrxwppntXrjCd0yOr7Ge3GI2Q3k76gmJtDAN12A==", "014388dd-4fb8-4ba3-8236-5f56f0f71d6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a281929-c945-4d18-b09f-efd9359de792", "AQAAAAEAACcQAAAAEGFogPEb0KlZproe4WRJw78yN+Sj0O74d5z1x6ZFg6uIMW1IvVLeHrx30l4U8Y08Gg==", "54ccefc8-9501-4fab-ae11-fc0169148304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da03531f-ce00-4434-abb7-3ebce308d85c", "AQAAAAEAACcQAAAAEFLs5ZC3I0qgoNWNp7dd9PXKnJFlhdBpByRH3+ED6jA+KpkUz8WXlV0upm8IIiTvNg==", "f58ae23c-1195-4d10-b5ac-173be38063ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84b05d38-35b9-4adb-9b53-1a4986eb5d82", "AQAAAAEAACcQAAAAEFSTGkoRrLH9ZNAgD+9xR++U7I5oVHcS8BC3fsuxbb74XG/0f/opCcxsVfijAk/N5A==", "e87c1512-4d6a-494e-b8a5-c1b5704e89ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73ef2c2c-884e-407b-b001-3bad983029fc", "AQAAAAEAACcQAAAAEMCkzqk4XW9ZR+nX85Y124SgshvtSoGOfB/ViUL1xrPhNaMONe+lrkoCpfV+5194+A==", "bd86711e-9a89-4464-906a-34f8dceef7d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d727324-53c8-43d1-b058-c3e8164b866c", "AQAAAAEAACcQAAAAELKp+zyH9iWpY7r7FFED+eSQLr1Zvxe8mIpcSgULDVz0sjFz+qs43cm7cA7/O7IzQg==", "82d7160b-10d1-466d-90f6-6d631ccf4436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15de83e3-abdb-4ab1-8eb8-0977e2cfc0b6", "AQAAAAEAACcQAAAAEDxkrCy5flTgp8ESADHKbEistFwfA/S9nttGZrZ2GyhAWELa6kg6zk5SQ29mAFN6uA==", "f84dae38-e0d8-4450-b6f1-39097ab2abaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc2b8af-6bcb-4b6e-8523-4cda4e5899c0", "AQAAAAEAACcQAAAAEHhz6IqCrrlzl33652AKYcYxVadqTq5BxeYT+UDPxJMRnjC3zTU+jVDA2ABdkMjLeQ==", "a1850960-ea95-43be-9755-84112f53b497" });

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

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "AboutUsText", "Address", "CreatedAt", "Email", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedInUrl", "Name", "Phone", "WelcomeText" },
                values: new object[] { 1, "About Ong", "Address Ong", new DateTime(2021, 7, 26, 23, 6, 27, 9, DateTimeKind.Local).AddTicks(901), "Email Ong", "Facebook Url", "https://placeimg.com/640/480/any", "Instagram Url", false, "Linedin Url", "ONG", "+54112563256", "Welcome Ong" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 512, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484310",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fadb6ab9-b537-450d-b332-6b1410713393", "AQAAAAEAACcQAAAAENlXLpUY/CJjRBsXzIvWVwOhPcA4BwQCoqpp18ocMp53bzT3j+F7So75UX90bM941A==", "aea1afa1-6412-464a-a8e1-edc4e6f36b28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd7bb431-e217-49da-8e6b-a5cada1ef772", "AQAAAAEAACcQAAAAEObRP1lIsD1s9j6wq/CUdB57pxVNRWZdx8pNVIxm95eODH6rKo821L3Umhw3u0OWsg==", "b26d133d-b2a9-4b21-959a-c11905c4e3cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f374133-97fa-4ec0-9948-e40bddd9c16f", "AQAAAAEAACcQAAAAELcn5kGsa6lm4Y0f0hbMIcbYag4ohms708Mx6XbpHOnK9bOyBLXgW1fXVPw3/eot2Q==", "ac574163-de2e-497b-a45b-2c850f934a07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7c6be13-8770-49d0-aa56-52853376087c", "AQAAAAEAACcQAAAAEN5Oh6ObECQzv41lQrQekiJLVh0ycIcfjddTUFeJJy9OkxigjeF0/HNJEmwhMBMOqg==", "a86efb7d-b827-40c9-96ab-960954f6b8db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ccd279-fdda-4811-9f7b-aff9fd121d36", "AQAAAAEAACcQAAAAEMyq6Sp8lRey+NE59ieDSXeqQbzRLt501sCFmd7mH6rj0SY3+781g+1C+QXntykhjw==", "ef4ff561-245e-43af-a555-d8b66e8d7e1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd5d6f28-2c4b-4ee9-b0fe-fc503fe89479", "AQAAAAEAACcQAAAAEInR4xAVjcrO3toP6U756EcuE2neSU11eua6wZ33HrqrqE2ks3lrNdgUOuXSB1eUHw==", "74b2dc00-7ce8-4285-b179-db090b9b51d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "491a99b0-500a-49ec-926c-319f5c12e96b", "AQAAAAEAACcQAAAAEI+HTQXTXTrfDQcr3zEt/056MOtyWL/IcW0qpjuCfOa4klkUlc7rHhNxdnOdjCBisw==", "83dce6d1-f9eb-420d-b069-240d7eb2a748" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddeddfa9-0e02-4824-bf66-c319a9ce2f92", "AQAAAAEAACcQAAAAEAp4amO0yhjCcyPE1WTf42I+9AmKHiUVF436nih3ut+8qmHxJiuGx4kV5Uo5R3R4Qg==", "f1b34016-c7c8-497f-a110-7759515f6d97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "863710fc-da05-41a3-b169-536b9762bf4d", "AQAAAAEAACcQAAAAEC3HICkH8lMy7aqEM8V1+93KvKcm9U/S5NHwj/bsSOBkfIFJpCxDSKOr3e6Kah9kCg==", "d83099ba-6901-40e1-8742-3bd40cbef886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c9a3fb-e4da-4d8e-ba69-d199682fd101", "AQAAAAEAACcQAAAAEDzNRYNs7+0ki+lQQbkSZ1g3ZJtztrySSQHfLvGitVY298iVYZCgiLGcVBr28qr7IQ==", "dffffce2-3c73-4aab-b83a-5c1c4eb943b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de61a425-253a-44ce-96e7-2277f5a1be6c", "AQAAAAEAACcQAAAAEHphpyWL+Ng/tCHrEPuR1ZAhUeU8uQgIVHJZA+Clxt2ou3LIcMbsK3LRLmVNABMQ5w==", "97196f76-6a23-48a1-ab45-4f9fc1960dbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4e30497-4c88-4dea-a9e9-f3afff1d117b", "AQAAAAEAACcQAAAAEAFS6MQF9qub7c8J2SfWE8ZEOHhuRJ5G7U3ukgV2wEq02VGOGMPXn/YCBrz5f734jw==", "e8d0062b-32e1-462a-9d33-3dc8ec0c8e12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1393ee1b-38a3-40e7-b510-129fda285850", "AQAAAAEAACcQAAAAEFW+xC6w1Sniyd90X18mPKvGDTYWxV7oXBxbmDuaL6xhl0VYpyKcxgUdxV88JVFQKQ==", "b5af6fa6-1f68-4cff-aada-02e2f2572cdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1490ea90-40a4-4e96-bbb0-b418d509a49e", "AQAAAAEAACcQAAAAENm63HJOYrCuT/2+cBpIGFDkdgbDobxz8OkfqkUOWq0uoBapSLyRubEguLJ0EDWJEQ==", "78319ace-57ee-4b36-826e-cbba8dc74d68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3fac74a-e885-4c4b-9e27-7fc7e3f942f6", "AQAAAAEAACcQAAAAEIdS4lH5Gdb7cCNLEJmvC/yJjLRCZ26nVYtJ5jHf6GKWcrHNxNJq7KejuQ30T3I3Rg==", "d34bff98-e19e-40c1-8563-3040217de1ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a80895b-594e-478f-a8f0-eced764b2e8e", "AQAAAAEAACcQAAAAEOBWHVstYDbUDk9Ioeoo6/gw9GJXI9xCl+Ejy6r8/c7fnnKpO27b0X7HWep74TnB4Q==", "994c6fa6-e997-48ad-87a1-ad519e5f3b79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "903d50ce-9d48-4650-a63b-47f88c6a4f81", "AQAAAAEAACcQAAAAEL7esLTc4hJGKUed45iGQcFquOlhjHr0l77XiC3jbrETdGp5syTihY6fbyToptr6pg==", "676480e7-0cf3-4a98-b72c-31cd30d3b20d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8398961c-550c-40e6-aa2d-695b8c21ad96", "AQAAAAEAACcQAAAAEAccTnUySDI2Rvr5diyayyO9Ijj9R4xMhaODbckSpPpyAu1ZwgqWsuKGqFdyX2k17w==", "98bf932f-32b2-4662-90d6-35308df6ce17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b22299da-0111-48c0-ad9c-9f01b950a8bb", "AQAAAAEAACcQAAAAEICLaQlfz6qd6bFHxO/RDsi7Lyh2FoFWBSJX0YraWK7hwHixL4QGrGyvJ8alSuZh/Q==", "614b848e-cf31-4c5b-a5a2-3c8c70b03c50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ec84590-35fc-48b8-97b6-9a08b270ba02", "AQAAAAEAACcQAAAAELD3GgAQtdcwSb3GRlEAw6vSk9F+olm2+3NDNy/cYgu2dz99syFifA5MyrqrFWOi+w==", "cc533d66-df2e-49a9-81f8-e227b0e063b9" });
        }
    }
}
