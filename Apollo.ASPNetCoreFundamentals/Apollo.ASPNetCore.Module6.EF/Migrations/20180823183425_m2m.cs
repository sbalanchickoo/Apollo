using Microsoft.EntityFrameworkCore.Migrations;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Migrations
{
    public partial class m2m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Restaurant",
                newName: "RestaurantRating");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Restaurant",
                newName: "RestaurantName");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Restaurant",
                newName: "RestaurantLocation");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurant",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cuisine",
                newName: "CuisineName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cuisine",
                newName: "CuisineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestaurantRating",
                table: "Restaurant",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "RestaurantName",
                table: "Restaurant",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RestaurantLocation",
                table: "Restaurant",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Restaurant",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CuisineName",
                table: "Cuisine",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CuisineId",
                table: "Cuisine",
                newName: "Id");
        }
    }
}
