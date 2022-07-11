using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(nullable: false),
                    DescricaoDoProduto = table.Column<string>(nullable: false),
                    situacaoDoProduto = table.Column<string>(nullable: true),
                    DataDeFabricacao = table.Column<string>(nullable: false),
                    DataDeValidade = table.Column<string>(nullable: false),
                    CodigoDoFornecedor = table.Column<string>(nullable: false),
                    DescricaoDoFornecedor = table.Column<string>(nullable: false),
                    CNPJDoFornecedor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Codigo",
                table: "User",
                column: "Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
