using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class populaususario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios (Nome, Email, Password, Foto) VALUES\r\n('João Silva', 'joao.silva@example.com', 'senha123', 'path/to/joao_silva.jpg'),\r\n('Maria Oliveira', 'maria.oliveira@example.com', 'senha456', 'path/to/maria_oliveira.jpg'),\r\n('Carlos Souza', 'carlos.souza@example.com', 'senha789', 'path/to/carlos_souza.jpg'),\r\n('Ana Costa', 'ana.costa@example.com', 'senha101', 'path/to/ana_costa.jpg'),\r\n('Fernanda Lima', 'fernanda.lima@example.com', 'senha102', 'path/to/fernanda_lima.jpg');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from usuarios");
        }
    }
}
