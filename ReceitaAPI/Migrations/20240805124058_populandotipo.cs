using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class populandotipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Receitas SET tipo = 'bolo' WHERE ReceitaId = 1;");
            migrationBuilder.Sql("UPDATE Receitas SET tipo = 'torta' WHERE ReceitaId = 2;");
            migrationBuilder.Sql("UPDATE Receitas SET tipo = 'sopa' WHERE ReceitaId = 3;");
            migrationBuilder.Sql("UPDATE Receitas SET tipo = 'lanche' WHERE ReceitaId = 4;");
            migrationBuilder.Sql("UPDATE Receitas SET tipo = 'salada' WHERE ReceitaId = 5;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
