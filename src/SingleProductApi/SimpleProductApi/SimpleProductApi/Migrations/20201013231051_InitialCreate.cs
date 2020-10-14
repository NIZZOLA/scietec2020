using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleProductApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 50, nullable: true),
                    Unidade = table.Column<int>(nullable: false),
                    ValorDeCusto = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    MargemDeLucro = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CodigoDeBarras = table.Column<string>(maxLength: 13, nullable: true),
                    Estoque = table.Column<decimal>(type: "decimal(12,3)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
