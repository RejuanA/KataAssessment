using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckoutKata.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "DiscountId", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "N/A", null, "https://via.placeholder.com/300x300", 10m, "A" },
                    { 2, "N/A", null, "https://via.placeholder.com/300x300", 15m, "B" },
                    { 3, "N/A", null, "https://via.placeholder.com/300x300", 40m, "C" },
                    { 4, "N/A", null, "https://via.placeholder.com/300x300", 55m, "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
