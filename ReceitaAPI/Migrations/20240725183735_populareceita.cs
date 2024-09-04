using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class populareceita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("-- Inserir dados de exemplo na tabela `Receitas`\r\nINSERT INTO Receitas (ReceitaName, Ingredientes, Instrucao, Tempo, UserId) VALUES\r\n('Bolo de Cenoura', 'Cenoura, farinha, açúcar, ovos, óleo', 'Misture todos os ingredientes e asse a 180 graus por 40 minutos.', '45 min', 1),\r\n('Lasanha', 'Massa de lasanha, molho de tomate, carne moída, queijo', 'Cozinhe a carne, monte as camadas de massa e recheio, e asse por 30 minutos.', '1 hora', 2),\r\n('Sopa de Legumes', 'Cenoura, batata, cebola, caldo de legumes', 'Cozinhe todos os ingredientes até ficarem macios.', '30 min', 3),\r\n('Pão de Queijo', 'Polvilho, queijo, ovos, leite', 'Misture tudo, forme bolinhas e asse por 20 minutos.', '30 min', 4),\r\n('Salada de Frutas', 'Maçã, banana, laranja, morango', 'Corte todas as frutas e misture.', '15 min', 5);\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from receitas");
        }
    }
}
