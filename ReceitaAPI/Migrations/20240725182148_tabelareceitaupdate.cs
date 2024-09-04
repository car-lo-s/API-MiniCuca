using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class tabelareceitaupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceitaName",
                table: "Receitas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ingredientes",
                table: "Receitas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "instrucao",
                table: "Receitas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "tempo",
                table: "Receitas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceitaName",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "ingredientes",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "instrucao",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "tempo",
                table: "Receitas");
        }
    }
}
