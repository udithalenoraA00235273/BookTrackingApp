using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAst3.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    NameToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryTypeType = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.NameToken);
                    table.ForeignKey(
                        name: "FK_Category_CategoryType_CategoryTypeType",
                        column: x => x.CategoryTypeType,
                        principalTable: "CategoryType",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryNameToken = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryNameToken",
                        column: x => x.CategoryNameToken,
                        principalTable: "Category",
                        principalColumn: "NameToken",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryNameToken",
                table: "Book",
                column: "CategoryNameToken");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryTypeType",
                table: "Category",
                column: "CategoryTypeType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "CategoryType");
        }
    }
}
