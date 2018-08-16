using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstoqueOnlineService.Migrations
{
    public partial class migrationSqlServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Categoria",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<string>(maxLength: 2, nullable: false, defaultValue: "AT")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classificacao",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<string>(maxLength: 2, nullable: false, defaultValue: "AT")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classificacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<string>(maxLength: 2, nullable: false, defaultValue: "AT"),
                    CategoriaId = table.Column<int>(nullable: false),
                    ClassificacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalSchema: "dbo",
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Material_Classificacao_ClassificacaoId",
                        column: x => x.ClassificacaoId,
                        principalSchema: "dbo",
                        principalTable: "Classificacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemMaterial",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaterialId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<string>(maxLength: 2, nullable: false, defaultValue: "AT")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "dbo",
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_ItemMaterialMaterial",
                schema: "dbo",
                table: "ItemMaterial",
                column: "MaterialId",
                filter: "[MaterialId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IDX_CategoriaMaterial",
                schema: "dbo",
                table: "Material",
                column: "CategoriaId",
                filter: "[CategoriaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Material_ClassificacaoId",
                schema: "dbo",
                table: "Material",
                column: "ClassificacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemMaterial",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Material",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categoria",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Classificacao",
                schema: "dbo");
        }
    }
}
