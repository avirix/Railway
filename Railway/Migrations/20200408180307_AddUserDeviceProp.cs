using Microsoft.EntityFrameworkCore.Migrations;

namespace Railway.Migrations
{
    public partial class AddUserDeviceProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserDevice",
                table: "Logins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserDevice",
                table: "Logins");
        }
    }
}
