using Microsoft.EntityFrameworkCore.Migrations;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeadChefId",
                table: "Restaurant",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadChefId",
                table: "Restaurant");
        }
    }
}
