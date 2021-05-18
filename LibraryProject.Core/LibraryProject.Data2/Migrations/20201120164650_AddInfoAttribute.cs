namespace LibraryProject.Data2.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddInfoAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Books");
        }
    }
}
