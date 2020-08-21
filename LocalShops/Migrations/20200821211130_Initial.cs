using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalShops.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NeighborhoodId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StarRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                    table.ForeignKey(
                        name: "FK_Restaurants_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NeighborhoodId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StarRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                    table.ForeignKey(
                        name: "FK_Shops_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Neighborhoods",
                columns: new[] { "NeighborhoodId", "Name" },
                values: new object[,]
                {
                    { 1, "Eastmorland" },
                    { 2, "Sellwood" },
                    { 3, "Woodstock" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Token", "Username" },
                values: new object[,]
                {
                    { 1, "noel", "Admin", null, "noel" },
                    { 2, "user", "User", null, "user" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Name", "NeighborhoodId", "StarRating", "Type" },
                values: new object[,]
                {
                    { 1, "Taco Express", 1, 3, "Mexican" },
                    { 2, "Betrie Lou's Cafe", 2, 3, " American breakfast/lunch" },
                    { 3, "Bellagios Pizza", 2, 4, "Italian" },
                    { 4, "Otto's", 3, 5, "German deli" },
                    { 5, "Tom Yum", 3, 5, "Thai" },
                    { 6, "Laughing Planet", 3, 3, "burritos/bowls" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Name", "NeighborhoodId", "StarRating", "Type" },
                values: new object[,]
                {
                    { 1, "Wallgreens", 1, 2, "drug store" },
                    { 2, "7/11", 1, 2, "convenience" },
                    { 3, "Snap Fitness", 2, 4, "gym/wellness" },
                    { 4, "Ace Hardware", 3, 3, "hardware store" },
                    { 5, "7/11", 3, 3, "convenience store" },
                    { 6, "New Seasons", 3, 5, "grocery store" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_NeighborhoodId",
                table: "Restaurants",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_NeighborhoodId",
                table: "Shops",
                column: "NeighborhoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Neighborhoods");
        }
    }
}
