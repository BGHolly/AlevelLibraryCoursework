namespace LibraryProject.Data2.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Safeguardingandextradetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Safeguarding",
                table: "Books",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Safeguarding",
                table: "Books");
        }
    }
}
