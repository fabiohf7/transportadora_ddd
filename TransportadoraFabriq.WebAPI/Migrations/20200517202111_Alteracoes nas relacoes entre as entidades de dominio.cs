using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportadoraFabriq.WebAPI.Migrations
{
    public partial class Alteracoesnasrelacoesentreasentidadesdedominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNH",
                table: "Motorista");

            migrationBuilder.AddColumn<DateTime>(
                name: "Validade",
                table: "Motorista",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Registro",
                table: "Motorista",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Validade",
                table: "Motorista");

            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Motorista");

            migrationBuilder.AddColumn<int>(
                name: "CNH",
                table: "Motorista",
                nullable: false,
                defaultValue: 0);
        }
    }
}
