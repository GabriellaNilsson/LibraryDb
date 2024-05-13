using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBook_Book_FkBookId",
                table: "CustomerBook");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBook_Customer_FkCustomerId",
                table: "CustomerBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerBook",
                table: "CustomerBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "CustomerBook",
                newName: "CustomerBooks");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerBook_FkCustomerId",
                table: "CustomerBooks",
                newName: "IX_CustomerBooks_FkCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerBook_FkBookId",
                table: "CustomerBooks",
                newName: "IX_CustomerBooks_FkBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerBooks",
                table: "CustomerBooks",
                column: "CustomerBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_Books_FkBookId",
                table: "CustomerBooks",
                column: "FkBookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_Customers_FkCustomerId",
                table: "CustomerBooks",
                column: "FkCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_Books_FkBookId",
                table: "CustomerBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_Customers_FkCustomerId",
                table: "CustomerBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerBooks",
                table: "CustomerBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "CustomerBooks",
                newName: "CustomerBook");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerBooks_FkCustomerId",
                table: "CustomerBook",
                newName: "IX_CustomerBook_FkCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerBooks_FkBookId",
                table: "CustomerBook",
                newName: "IX_CustomerBook_FkBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerBook",
                table: "CustomerBook",
                column: "CustomerBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBook_Book_FkBookId",
                table: "CustomerBook",
                column: "FkBookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBook_Customer_FkCustomerId",
                table: "CustomerBook",
                column: "FkCustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
