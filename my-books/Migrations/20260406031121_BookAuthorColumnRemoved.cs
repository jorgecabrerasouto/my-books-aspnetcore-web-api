using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class BookAuthorColumnRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisherss_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisherss",
                table: "Publisherss");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Publisherss",
                newName: "Publishers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Publisherss");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisherss",
                table: "Publisherss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisherss_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publisherss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
