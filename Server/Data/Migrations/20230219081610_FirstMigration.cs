using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "05131a62-a86a-4664-8d51-b8d5d65be128", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/16/500", 16000L, "Product 16" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "0837a526-2e40-4b27-9dd3-cdaf8cbc6e95", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/4/500", 4000L, "Product 4" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "13509d95-9af0-4bfa-9db8-a39eef026069", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/3/500", 3000L, "Product 3" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "2b6e6b3f-87f0-4cf0-8ec5-71bb9feca57a", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/11/500", 11000L, "Product 11" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "2c529933-31a5-47f7-a6c5-7e25c2f56806", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/19/500", 19000L, "Product 19" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "39c2c8a8-3444-40ad-9dad-2c0aabc4ad99", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/17/500", 17000L, "Product 17" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "4266b6a2-d3fb-43c4-8dc0-5ddc6fb017f1", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/6/500", 6000L, "Product 6" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "49656166-6998-487e-b6d2-b8944bf34f91", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/12/500", 12000L, "Product 12" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "4a51a910-ba40-4cdb-b870-4ec4ebab21cc", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/10/500", 10000L, "Product 10" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "5411f6b0-c9e9-4041-ab64-4dcb4d1a1a24", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/8/500", 8000L, "Product 8" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "5692c4c0-51ae-4407-a7c1-ff81ae753040", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/1/500", 1000L, "Product 1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "58973be6-cf95-4ad4-a386-3b220e34e839", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/5/500", 5000L, "Product 5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "6f095597-26c3-4531-9bde-d344df9ee465", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/15/500", 15000L, "Product 15" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "75949e7e-aacc-4bda-84f0-aaac09300bfa", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/2/500", 2000L, "Product 2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "86f5935b-a6ef-4386-b28d-90252dada815", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/14/500", 14000L, "Product 14" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "93940761-d15c-4d78-8187-56ec0ece74b2", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/18/500", 18000L, "Product 18" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "93c16a7d-1413-4912-bd89-d4431bf64d61", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/13/500", 13000L, "Product 13" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "d1c91508-ebd9-44e9-99e4-ba94cc249814", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/7/500", 7000L, "Product 7" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "ead264d6-9866-443f-adc5-863fe60a37c9", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/9/500", 9000L, "Product 9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "f504e2ea-58d1-474d-ae89-57ef6b6777ff", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/20/500", 20000L, "Product 20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
