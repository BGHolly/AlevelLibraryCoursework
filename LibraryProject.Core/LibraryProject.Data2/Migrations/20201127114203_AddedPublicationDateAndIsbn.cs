namespace LibraryProject.Data2.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedPublicationDateAndIsbn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicationDate",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "Books");
        }
    }
}
