using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class activities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Member",
                table: "Member");

            migrationBuilder.RenameTable(
                name: "Member",
                newName: "Members");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Test number 1", new DateTime(2021, 7, 26, 23, 3, 59, 512, DateTimeKind.Local).AddTicks(8823), "https://placeimg.com/640/480/any", false, "Activity number 1" },
                    { 2, "Test number 2", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(8948), "https://placeimg.com/640/480/any", false, "Activity number 2" },
                    { 3, "Test number 3", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(8988), "https://placeimg.com/640/480/any", false, "Activity number 3" },
                    { 4, "Test number 4", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9006), "https://placeimg.com/640/480/any", false, "Activity number 4" },
                    { 5, "Test number 5", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9021), "https://placeimg.com/640/480/any", false, "Activity number 5" },
                    { 6, "Test number 6", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9039), "https://placeimg.com/640/480/any", false, "Activity number 6" },
                    { 7, "Test number 7", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9054), "https://placeimg.com/640/480/any", false, "Activity number 7" },
                    { 8, "Test number 8", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9069), "https://placeimg.com/640/480/any", false, "Activity number 8" },
                    { 9, "Test number 9", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9083), "https://placeimg.com/640/480/any", false, "Activity number 9" },
                    { 10, "Test number 10", new DateTime(2021, 7, 26, 23, 3, 59, 513, DateTimeKind.Local).AddTicks(9197), "https://placeimg.com/640/480/any", false, "Activity number 10" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "Members",
                newName: "Member");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Member",
                table: "Member",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484310",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "780308a0-808d-4707-9314-329138961afe", "AQAAAAEAACcQAAAAEEFVxwPtFa8Nklo8puS7IfV8fSstBuZ4wr1kBrObxXzFTisdKmSleB34vU3ju7vySg==", "b83bf0d5-126e-4182-8d11-03d5f6283f26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484311",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb903d69-7949-49c1-b1e3-fccbe1f32bb4", "AQAAAAEAACcQAAAAEAs2KH6ISy4dq9N39yEaYj8oYXW92wurOOKXcFS3FBQgR7XE3IHYs8zgD2P+4SApwg==", "1aaecce6-bad8-4fbb-bf7d-7eabbdf609d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484312",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dea823d7-6103-474e-b1d0-77fa5860a9a8", "AQAAAAEAACcQAAAAEE6KShzOeSAhYdPlgtciteZS8MTcdKi3CQNjztNsboluNBHuFpDRjijp9ruoiGntZw==", "ff383dba-819f-4863-887e-b6197a467c01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484313",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cd1ed71-4a9d-462a-b764-e6ff93709838", "AQAAAAEAACcQAAAAEEYHvp1UQQiwQLQ6DR+aaBOTIwB+PmGmWmMxZTrR57D8ltea5RQ62ahL+TOYrMtVZg==", "51bd39e9-2d21-4ad7-b763-050e3336b944" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484314",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "068f82c3-8e43-481f-b88d-08784da0ae04", "AQAAAAEAACcQAAAAEFE7SyL75rLEpBrXzeJo0zl6QzDntsZo20vE34aMjTBwYQXcr3Iz7cvId/TDAqj8Og==", "a0748b59-7a2a-4283-953f-74bd4f259afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484315",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c344daa-d51c-4845-9ec6-fcc7500ea6e0", "AQAAAAEAACcQAAAAEBJ3G5EMhd6/X5t9DrZqDZZun1fjYKPVe5rrMbgmfBdORgUfNuIGawR/mKHwf9CX0w==", "77c2be2c-fd1f-4519-8170-daa7f7a2460e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484316",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53f809a5-8f82-4d5b-8aa5-6306ff827756", "AQAAAAEAACcQAAAAEBV4FtKAhxyQveaH6EJhpUXSgeGfnR6owNr9d9wc0Vbdq2ucfdRMQ78F35fx4bgadQ==", "867fed5b-c578-4fe3-9848-5ad8b06ee58b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484317",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad0b51d-d55e-4206-b3c1-380ecce99e17", "AQAAAAEAACcQAAAAELLn4tMuN30emgqLqO/y3ZAufCaWm+V118VeU4aKlsgWl1CGnYu7ry/xUWprDhK2OA==", "82d4610f-9d75-44cf-a4de-f52527c47728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484318",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed58c08-1bf2-47dd-885c-d477cde83113", "AQAAAAEAACcQAAAAEKxLsJE9SoOHHIWCks9YsN/+m2avQPJ6eUgE0UQO09lpy/FG4T3dr61GHZdxb6DdvA==", "4e14e9f2-2beb-425a-bde5-7e3da382497d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484319",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9704707-caca-4688-aad2-e67937298589", "AQAAAAEAACcQAAAAELkEiChvvwRniEDyNuKF3ELlcNVyXDqwl7Wqr4d5jQabbsz0/GKj7O8dF6yyc0kltQ==", "7a0d4fc8-d861-447e-b8b0-5d424ce8a265" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "399e5ae5-262e-407f-9e16-6d79f7d1e977", "AQAAAAEAACcQAAAAEK3HMA1wexXvQ+FMCXdb2gwiirpLsdu3zah83AUOM/l2tR7r+Vys3FTS+v/kxfM06g==", "d850fa49-f0fb-4f07-ad11-dabeac389474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484331",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd71c028-4c43-4453-9cac-23851835542f", "AQAAAAEAACcQAAAAEMA9G4c+ttqRhuItGFgbXbwurKy4dxGf/8NDAldQpNxop8QMwp2z6zMT1nWnjjhrYg==", "f26d849d-ac95-4589-adba-e3f978fd4a9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aef7b02-fd73-42ae-ab63-0af1f64fd9a4", "AQAAAAEAACcQAAAAEL8HuB1ORnrHOmmn5AHGus5OYORzG/6ibpZF/KU3bhgBlve0rq+6yH0rJSkHnOD6Ww==", "4e2f357e-e40f-49a8-be0e-de2948f79336" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c59b6729-d14c-4612-b604-aaa8caffaad9", "AQAAAAEAACcQAAAAEP78cb5OIvPYb+tnuDl3+8FBPGdJKyoA2eJlH4pQTTBbSPTjrDCmR3GGvsXvzX63rw==", "6e0dd3eb-9ba5-46f1-9d4d-fe176c0308a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484334",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2f520b3-40c1-4769-99cc-75fe9bb04e96", "AQAAAAEAACcQAAAAEBu47XmDr8MelfLnPqlw2uklvPYLgHj5frKOhRwnWWXWiLoGOVakEpkm1d98G/8Vmw==", "c9689bab-bcd5-4075-82e6-3a4ac0762572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484335",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a787ac9-d836-4b9b-86df-ec0a0fb03e94", "AQAAAAEAACcQAAAAEFUS3L10tMyTuiJsBlD0VarOTM1P/yTt5HxJMsjhKi6VipYWKRvIR0PRuYQ7YEP2eg==", "5bfa64e3-2472-47a7-b296-0ed9a37053c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484336",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfa1100b-69fe-4813-895b-42b1ba2a6227", "AQAAAAEAACcQAAAAEL/526DUVkwPd1AKlvDF/OB3EFHtFdXsq1Z3d2hBHgQbPy34SFvioYdEBXsaA44NNg==", "94741c65-5580-454a-a27b-a1bfc782e519" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484337",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1188e1d3-cc82-48d4-bfef-9f2969ea8a22", "AQAAAAEAACcQAAAAEGj/FgoDzxxZfZUxYm8it7dcBcDlZ5hw+L7P1tvnE+k5FbMVG+H9MaeBk5PQpjfNvw==", "44c2a0fb-b4ad-4920-8d45-e6e62c290b1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d094b1c-01f9-4daf-baf2-181c2b4762bd", "AQAAAAEAACcQAAAAEDnp2xc9JlciwJD8tjme3Q/Ebt5o/se+iWjqTwM7JvRm4qanA7P31dqXflDFnau8xg==", "54fef47d-c807-4a9e-a3df-9613dac409d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db1255484339",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0037b09-3ed6-43a6-b2c0-18a94de86a54", "AQAAAAEAACcQAAAAEL8+6wZqvYsrAf5RTM8mRSdyrZCVk/LNqGtQ/gUfzuUthtL+mMS8ZlW2IqXylVa8tQ==", "04360e04-d150-41b8-af26-9d34e94f785a" });
        }
    }
}
