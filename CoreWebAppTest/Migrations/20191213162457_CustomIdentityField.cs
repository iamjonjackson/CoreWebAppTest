using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebAppTest.Migrations
{
    public partial class CustomIdentityField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomField",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomField",
                table: "AspNetUsers");
        }
    }
}
