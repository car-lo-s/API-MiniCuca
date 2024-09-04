using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class populaimagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Receitas\r\nSET receitaimg = 'https://cdn-icons-png.flaticon.com/256/4080/4080188.png'\r\nWHERE ReceitaId = 1;");
            migrationBuilder.Sql("UPDATE Receitas\r\nSET receitaimg = 'https://cdn-icons-png.flaticon.com/256/1746/1746273.png'\r\nWHERE ReceitaId = 2;");
            migrationBuilder.Sql("UPDATE Receitas\r\nSET receitaimg = 'https://cdn-icons-png.flaticon.com/512/2082/2082088.png'\r\nWHERE ReceitaId = 3;");
            migrationBuilder.Sql("UPDATE Receitas\r\nSET receitaimg = 'https://cdn-icons-png.flaticon.com/512/8692/8692234.png'\r\nWHERE ReceitaId = 4;");
            migrationBuilder.Sql("UPDATE Receitas\r\nSET receitaimg = 'https://cdn-icons-png.flaticon.com/256/415/415693.png'\r\nWHERE ReceitaId = 5;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
