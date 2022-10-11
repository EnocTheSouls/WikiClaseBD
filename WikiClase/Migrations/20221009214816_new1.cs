using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiClase.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Tag_tagId",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_tagId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "tagId",
                table: "Categorias");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_categoriaId",
                table: "Tag",
                column: "categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Categorias_categoriaId",
                table: "Tag",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Categorias_categoriaId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_categoriaId",
                table: "Tag");

            migrationBuilder.AddColumn<int>(
                name: "tagId",
                table: "Categorias",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_tagId",
                table: "Categorias",
                column: "tagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Tag_tagId",
                table: "Categorias",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "Id");
        }
    }
}
