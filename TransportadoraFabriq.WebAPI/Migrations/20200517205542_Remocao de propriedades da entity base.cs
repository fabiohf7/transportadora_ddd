using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportadoraFabriq.WebAPI.Migrations
{
    public partial class Remocaodepropriedadesdaentitybase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "UsuarioAtualizacao",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Motorista");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Motorista");

            migrationBuilder.DropColumn(
                name: "UsuarioAtualizacao",
                table: "Motorista");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Motorista");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Itinerario");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Itinerario");

            migrationBuilder.DropColumn(
                name: "UsuarioAtualizacao",
                table: "Itinerario");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Itinerario");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "UsuarioAtualizacao",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Destinatario");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Destinatario");

            migrationBuilder.DropColumn(
                name: "UsuarioAtualizacao",
                table: "Destinatario");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Destinatario");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Comprovante");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Comprovante");

            migrationBuilder.DropColumn(
                name: "UsuarioAtualizacao",
                table: "Comprovante");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Comprovante");

            migrationBuilder.RenameColumn(
                name: "Registro",
                table: "Motorista",
                newName: "RegistroCnh");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "Motorista",
                newName: "ValidadeCnh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistroCnh",
                table: "Motorista",
                newName: "Registro");

            migrationBuilder.RenameColumn(
                name: "ValidadeCnh",
                table: "Motorista",
                newName: "Validade");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Veiculo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Veiculo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAtualizacao",
                table: "Veiculo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Veiculo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Motorista",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Motorista",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAtualizacao",
                table: "Motorista",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Motorista",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Itinerario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Itinerario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAtualizacao",
                table: "Itinerario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Itinerario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Entrega",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Entrega",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAtualizacao",
                table: "Entrega",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Entrega",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Destinatario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Destinatario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAtualizacao",
                table: "Destinatario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Destinatario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Comprovante",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Comprovante",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAtualizacao",
                table: "Comprovante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Comprovante",
                nullable: true);
        }
    }
}
