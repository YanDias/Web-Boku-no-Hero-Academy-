using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(maxLength: 10, nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Senha = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    Sobre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                });

            migrationBuilder.CreateTable(
                name: "Avisos",
                columns: table => new
                {
                    IdAviso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avisos", x => x.IdAviso);
                });

            migrationBuilder.CreateTable(
                name: "ListaTreinos",
                columns: table => new
                {
                    IdListaTreino = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DSemana = table.Column<string>(nullable: false),
                    NomeLista = table.Column<string>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaTreinos", x => x.IdListaTreino);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    IdProfessor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Senha = table.Column<string>(nullable: true),
                    Especialidade = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.IdProfessor);
                });

            migrationBuilder.CreateTable(
                name: "ImcAlunos",
                columns: table => new
                {
                    IMCId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: true),
                    Peso = table.Column<double>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    CalcImc = table.Column<double>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImcAlunos", x => x.IMCId);
                    table.ForeignKey(
                        name: "FK_ImcAlunos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    IdExercicios = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Equipamento = table.Column<string>(nullable: true),
                    ListaTreinoIdListaTreino = table.Column<int>(nullable: true),
                    Repeticoes = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.IdExercicios);
                    table.ForeignKey(
                        name: "FK_Exercicios_ListaTreinos_ListaTreinoIdListaTreino",
                        column: x => x.ListaTreinoIdListaTreino,
                        principalTable: "ListaTreinos",
                        principalColumn: "IdListaTreino",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    IdAula = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Vagas = table.Column<int>(nullable: false),
                    ProfessorIdProfessor = table.Column<int>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.IdAula);
                    table.ForeignKey(
                        name: "FK_Aulas_Professores_ProfessorIdProfessor",
                        column: x => x.ProfessorIdProfessor,
                        principalTable: "Professores",
                        principalColumn: "IdProfessor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treinos",
                columns: table => new
                {
                    IdTreino = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ListaTreinoIdListaTreino = table.Column<int>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    ProfessorIdProfessor = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: true),
                    Periodo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinos", x => x.IdTreino);
                    table.ForeignKey(
                        name: "FK_Treinos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treinos_ListaTreinos_ListaTreinoIdListaTreino",
                        column: x => x.ListaTreinoIdListaTreino,
                        principalTable: "ListaTreinos",
                        principalColumn: "IdListaTreino",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treinos_Professores_ProfessorIdProfessor",
                        column: x => x.ProfessorIdProfessor,
                        principalTable: "Professores",
                        principalColumn: "IdProfessor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_ProfessorIdProfessor",
                table: "Aulas",
                column: "ProfessorIdProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_ListaTreinoIdListaTreino",
                table: "Exercicios",
                column: "ListaTreinoIdListaTreino");

            migrationBuilder.CreateIndex(
                name: "IX_ImcAlunos_AlunoId",
                table: "ImcAlunos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_AlunoId",
                table: "Treinos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_ListaTreinoIdListaTreino",
                table: "Treinos",
                column: "ListaTreinoIdListaTreino");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_ProfessorIdProfessor",
                table: "Treinos",
                column: "ProfessorIdProfessor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Avisos");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "ImcAlunos");

            migrationBuilder.DropTable(
                name: "Treinos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "ListaTreinos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
