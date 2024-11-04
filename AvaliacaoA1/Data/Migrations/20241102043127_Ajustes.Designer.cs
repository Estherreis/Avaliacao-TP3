﻿// <auto-generated />
using System;
using AvaliacaoA1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AvaliacaoA1.Data.Migrations
{
    [DbContext(typeof(AvaliacaoA1Context))]
    [Migration("20241102043127_Ajustes")]
    partial class Ajustes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AvaliacaoA1.Models.Lembrete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Lembrete");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.MembroReuniao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<int>("ReuniaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("ReuniaoId");

                    b.ToTable("MembroReuniao");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.MembroTarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<int>("TarefaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("TarefaId");

                    b.ToTable("MembroTarefa");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Pontuacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<int>("Pontos")
                        .HasColumnType("int");

                    b.Property<int>("TarefaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("TarefaId");

                    b.ToTable("Pontuacao");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Recompensa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustoEmPontos")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Recompensa");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Reuniao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Reuniao");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Concluida")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Lembrete", b =>
                {
                    b.HasOne("AvaliacaoA1.Models.Membro", "Membro")
                        .WithMany("Lembretes")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.MembroReuniao", b =>
                {
                    b.HasOne("AvaliacaoA1.Models.Membro", "Membro")
                        .WithMany("MembroReunioes")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvaliacaoA1.Models.Reuniao", "Reuniao")
                        .WithMany("MembroReunioes")
                        .HasForeignKey("ReuniaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membro");

                    b.Navigation("Reuniao");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.MembroTarefa", b =>
                {
                    b.HasOne("AvaliacaoA1.Models.Membro", "Membro")
                        .WithMany("MembroTarefas")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvaliacaoA1.Models.Tarefa", "Tarefa")
                        .WithMany("MembroTarefas")
                        .HasForeignKey("TarefaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membro");

                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Pontuacao", b =>
                {
                    b.HasOne("AvaliacaoA1.Models.Membro", "Membro")
                        .WithMany("Pontuacoes")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvaliacaoA1.Models.Tarefa", "Tarefa")
                        .WithMany("Pontuacoes")
                        .HasForeignKey("TarefaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membro");

                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Recompensa", b =>
                {
                    b.HasOne("AvaliacaoA1.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Membro", b =>
                {
                    b.Navigation("Lembretes");

                    b.Navigation("MembroReunioes");

                    b.Navigation("MembroTarefas");

                    b.Navigation("Pontuacoes");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Reuniao", b =>
                {
                    b.Navigation("MembroReunioes");
                });

            modelBuilder.Entity("AvaliacaoA1.Models.Tarefa", b =>
                {
                    b.Navigation("MembroTarefas");

                    b.Navigation("Pontuacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
