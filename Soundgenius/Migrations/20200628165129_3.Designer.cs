﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Soundgenius.Data;

namespace Soundgenius.Migrations
{
    [DbContext(typeof(SoundgeniusDB))]
    [Migration("20200628165129_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Soundgenius.Models.AlbumFaixas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumFK")
                        .HasColumnType("int");

                    b.Property<int>("FaixaFK")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AlbumFK");

                    b.HasIndex("FaixaFK");

                    b.ToTable("AlbumFaixas");
                });

            modelBuilder.Entity("Soundgenius.Models.Albuns", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FicheiroImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtilizadorFK")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UtilizadorFK");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("Soundgenius.Models.Faixas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FicheiroImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Faixas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Autor = "Luís Freitas",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "813635582",
                            Titulo = "M"
                        },
                        new
                        {
                            ID = 2,
                            Autor = "Andreia Gomes",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "854613462",
                            Titulo = "F"
                        },
                        new
                        {
                            ID = 3,
                            Autor = "Cristina Sousa",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "265368715",
                            Titulo = "F"
                        },
                        new
                        {
                            ID = 4,
                            Autor = "Sónia Rosa",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "835623190",
                            Titulo = "F"
                        },
                        new
                        {
                            ID = 5,
                            Autor = "António Santos",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "751512205",
                            Titulo = "M"
                        },
                        new
                        {
                            ID = 6,
                            Autor = "Gustavo Alves",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "728663835",
                            Titulo = "M"
                        },
                        new
                        {
                            ID = 7,
                            Autor = "Rosa Vieira",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "644388118",
                            Titulo = "F"
                        },
                        new
                        {
                            ID = 8,
                            Autor = "Daniel Dias",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "262618487",
                            Titulo = "M"
                        },
                        new
                        {
                            ID = 9,
                            Autor = "Tânia Gomes",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "842615197",
                            Titulo = "F"
                        },
                        new
                        {
                            ID = 10,
                            Autor = "Andreia Correia",
                            FicheiroImg = "dsfhshdfs",
                            Genero = "635139506",
                            Titulo = "F"
                        });
                });

            modelBuilder.Entity("Soundgenius.Models.Utilizador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaFacebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusicaPerf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("Soundgenius.Models.AlbumFaixas", b =>
                {
                    b.HasOne("Soundgenius.Models.Albuns", "Album")
                        .WithMany("AlbumFaixas")
                        .HasForeignKey("AlbumFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Soundgenius.Models.Faixas", "Faixa")
                        .WithMany("AlbumFaixas")
                        .HasForeignKey("FaixaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Soundgenius.Models.Albuns", b =>
                {
                    b.HasOne("Soundgenius.Models.Utilizador", "Utilizador")
                        .WithMany("ListaAlbum")
                        .HasForeignKey("UtilizadorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
