using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportadoraFabriq.WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioCadastro = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    UsuarioAtualizacao = table.Column<string>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    CNH = table.Column<int>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioCadastro = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    UsuarioAtualizacao = table.Column<string>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Placa = table.Column<string>(nullable: true),
                    Renavam = table.Column<string>(nullable: true),
                    Chassi = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    CapacidadeCarga = table.Column<double>(nullable: false),
                    Refrigerado = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itinerario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioCadastro = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    UsuarioAtualizacao = table.Column<string>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    MotoristaId = table.Column<Guid>(nullable: true),
                    VeiculoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itinerario_Motorista_MotoristaId",
                        column: x => x.MotoristaId,
                        principalTable: "Motorista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Itinerario_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entrega",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioCadastro = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    UsuarioAtualizacao = table.Column<string>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    ItinerarioId = table.Column<Guid>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrega", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrega_Itinerario_ItinerarioId",
                        column: x => x.ItinerarioId,
                        principalTable: "Itinerario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comprovante",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioCadastro = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    UsuarioAtualizacao = table.Column<string>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    EntregaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprovante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comprovante_Entrega_EntregaId",
                        column: x => x.EntregaId,
                        principalTable: "Entrega",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destinatario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioCadastro = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    UsuarioAtualizacao = table.Column<string>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    EntregaId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinatario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinatario_Entrega_EntregaId",
                        column: x => x.EntregaId,
                        principalTable: "Entrega",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comprovante_EntregaId",
                table: "Comprovante",
                column: "EntregaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinatario_EntregaId",
                table: "Destinatario",
                column: "EntregaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_ItinerarioId",
                table: "Entrega",
                column: "ItinerarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerario_MotoristaId",
                table: "Itinerario",
                column: "MotoristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerario_VeiculoId",
                table: "Itinerario",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comprovante");

            migrationBuilder.DropTable(
                name: "Destinatario");

            migrationBuilder.DropTable(
                name: "Entrega");

            migrationBuilder.DropTable(
                name: "Itinerario");

            migrationBuilder.DropTable(
                name: "Motorista");

            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
