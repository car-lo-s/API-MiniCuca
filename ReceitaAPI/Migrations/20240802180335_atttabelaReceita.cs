using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class atttabelaReceita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "receitaimg",
                table: "Receitas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "receitaimg",
                table: "Receitas");
        }
    }
}
