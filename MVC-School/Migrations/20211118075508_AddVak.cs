using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class addVak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocentId",
                table: "Docent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vakken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DocentId = table.Column<int>(type: "int", nullable: false),
                    VakkenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vakken_Vakken_VakkenId",
                        column: x => x.VakkenId,
                        principalTable: "Vakken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docent_DocentId",
                table: "Docent",
                column: "DocentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_VakkenId",
                table: "Vakken",
                column: "VakkenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Docent_DocentId",
                table: "Docent",
                column: "DocentId",
                principalTable: "Docent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Docent_DocentId",
                table: "Docent");

            migrationBuilder.DropTable(
                name: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Docent_DocentId",
                table: "Docent");

            migrationBuilder.DropColumn(
                name: "DocentId",
                table: "Docent");
        }
    }
}
