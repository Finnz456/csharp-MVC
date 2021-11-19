using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class newVak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Docent_DocentId",
                table: "Docent");

            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Vakken_VakkenId",
                table: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Docent_DocentId",
                table: "Docent");

            migrationBuilder.DropColumn(
                name: "DocentId",
                table: "Docent");

            migrationBuilder.RenameColumn(
                name: "VakkenId",
                table: "Vakken",
                newName: "vakkenId");

            migrationBuilder.RenameIndex(
                name: "IX_Vakken_VakkenId",
                table: "Vakken",
                newName: "IX_Vakken_vakkenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken",
                column: "DocentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Docent_DocentId",
                table: "Vakken",
                column: "DocentId",
                principalTable: "Docent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Vakken_vakkenId",
                table: "Vakken",
                column: "vakkenId",
                principalTable: "Vakken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Docent_DocentId",
                table: "Vakken");

            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Vakken_vakkenId",
                table: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken");

            migrationBuilder.RenameColumn(
                name: "vakkenId",
                table: "Vakken",
                newName: "VakkenId");

            migrationBuilder.RenameIndex(
                name: "IX_Vakken_vakkenId",
                table: "Vakken",
                newName: "IX_Vakken_VakkenId");

            migrationBuilder.AddColumn<int>(
                name: "DocentId",
                table: "Docent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Docent_DocentId",
                table: "Docent",
                column: "DocentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Docent_DocentId",
                table: "Docent",
                column: "DocentId",
                principalTable: "Docent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Vakken_VakkenId",
                table: "Vakken",
                column: "VakkenId",
                principalTable: "Vakken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
