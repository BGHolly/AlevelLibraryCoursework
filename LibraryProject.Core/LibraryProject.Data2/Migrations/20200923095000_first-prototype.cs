namespace LibraryProject.Data2.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Firstprototype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Returns_Users_UserEmail",
                table: "Returns");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.AddForeignKey(
                name: "FK_Returns_Users_UserEmail",
                table: "Returns",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Returns_Users_UserEmail",
                table: "Returns");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookBarcode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                    table.ForeignKey(
                        name: "FK_Authors_Books_BookBarcode",
                        column: x => x.BookBarcode,
                        principalTable: "Books",
                        principalColumn: "Barcode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookBarcode",
                table: "Authors",
                column: "BookBarcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Returns_Users_UserEmail",
                table: "Returns",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
