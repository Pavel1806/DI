using Microsoft.EntityFrameworkCore.Migrations;

namespace DI.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "As",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_As", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    AId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bs_As_AId",
                        column: x => x.AId,
                        principalTable: "As",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    BId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cs_Bs_BId",
                        column: x => x.BId,
                        principalTable: "Bs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bs_AId",
                table: "Bs",
                column: "AId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cs_BId",
                table: "Cs",
                column: "BId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cs");

            migrationBuilder.DropTable(
                name: "Bs");

            migrationBuilder.DropTable(
                name: "As");
        }
    }
}
