﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportadoraFabriq.Infra.Data.Context;

namespace TransportadoraFabriq.WebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Comprovante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<Guid>("EntregaId");

                    b.Property<string>("UsuarioAtualizacao");

                    b.Property<string>("UsuarioCadastro");

                    b.HasKey("Id");

                    b.HasIndex("EntregaId")
                        .IsUnique();

                    b.ToTable("Comprovante");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Destinatario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Endereco");

                    b.Property<Guid>("EntregaId");

                    b.Property<string>("Nome");

                    b.Property<string>("UsuarioAtualizacao");

                    b.Property<string>("UsuarioCadastro");

                    b.HasKey("Id");

                    b.HasIndex("EntregaId")
                        .IsUnique();

                    b.ToTable("Destinatario");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Entrega", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<Guid>("ItinerarioId");

                    b.Property<string>("UsuarioAtualizacao");

                    b.Property<string>("UsuarioCadastro");

                    b.HasKey("Id");

                    b.HasIndex("ItinerarioId");

                    b.ToTable("Entrega");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Itinerario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<Guid?>("MotoristaId");

                    b.Property<string>("UsuarioAtualizacao");

                    b.Property<string>("UsuarioCadastro");

                    b.Property<Guid?>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("MotoristaId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Itinerario");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Motorista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<int>("CNH");

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("UsuarioAtualizacao");

                    b.Property<string>("UsuarioCadastro");

                    b.HasKey("Id");

                    b.ToTable("Motorista");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Veiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<double>("CapacidadeCarga");

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("Refrigerado");

                    b.Property<string>("UsuarioAtualizacao");

                    b.Property<string>("UsuarioCadastro");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Comprovante", b =>
                {
                    b.HasOne("TransportadoraFabriq.Domain.Transporte.Entrega", "Entrega")
                        .WithOne("Comprovate")
                        .HasForeignKey("TransportadoraFabriq.Domain.Transporte.Comprovante", "EntregaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Destinatario", b =>
                {
                    b.HasOne("TransportadoraFabriq.Domain.Transporte.Entrega", "Entrega")
                        .WithOne("Destinatario")
                        .HasForeignKey("TransportadoraFabriq.Domain.Transporte.Destinatario", "EntregaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Entrega", b =>
                {
                    b.HasOne("TransportadoraFabriq.Domain.Transporte.Itinerario", "Itinerario")
                        .WithMany("Entregas")
                        .HasForeignKey("ItinerarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Itinerario", b =>
                {
                    b.HasOne("TransportadoraFabriq.Domain.Transporte.Motorista", "Motorista")
                        .WithMany()
                        .HasForeignKey("MotoristaId");

                    b.HasOne("TransportadoraFabriq.Domain.Transporte.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("TransportadoraFabriq.Domain.Transporte.Veiculo", b =>
                {
                    b.OwnsOne("TransportadoraFabriq.Domain.Transporte.ValueObjects.CRLV", "CRLV", b1 =>
                        {
                            b1.Property<Guid>("VeiculoId");

                            b1.Property<string>("Chassi")
                                .HasColumnName("Chassi");

                            b1.Property<string>("Marca")
                                .HasColumnName("Marca");

                            b1.Property<string>("Placa")
                                .HasColumnName("Placa");

                            b1.Property<string>("Renavam")
                                .HasColumnName("Renavam");

                            b1.HasKey("VeiculoId");

                            b1.ToTable("Veiculo");

                            b1.HasOne("TransportadoraFabriq.Domain.Transporte.Veiculo")
                                .WithOne("CRLV")
                                .HasForeignKey("TransportadoraFabriq.Domain.Transporte.ValueObjects.CRLV", "VeiculoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
