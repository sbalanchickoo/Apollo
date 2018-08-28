using Microsoft.EntityFrameworkCore.Migrations;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_HeadChefId",
                table: "Restaurant",
                column: "HeadChefId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Restaurant_HeadChefId",
                table: "Restaurant");
        }
    }
}
