using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relationships.Migrations
{
    public partial class OverrideConventionsUsingDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "AlbumTag",
                columns: table => new
                {
                    AlbID = table.Column<long>(type: "INTEGER", nullable: false),
                    TID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTag", x => new { x.AlbID, x.TID });
                    table.ForeignKey(
                        name: "FK_AlbumTag_Albums_AlbID",
                        column: x => x.AlbID,
                        principalTable: "Albums",
                        principalColumn: "AlbID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumTag_Tags_TID",
                        column: x => x.TID,
                        principalTable: "Tags",
                        principalColumn: "TID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTag_TID",
                table: "AlbumTag",
                column: "TID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumTag");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
