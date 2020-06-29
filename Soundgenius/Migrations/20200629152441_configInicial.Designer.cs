﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Soundgenius.Data;

namespace Soundgenius.Migrations
{
    [DbContext(typeof(SoundgeniusDB))]
    [Migration("20200629152441_configInicial")]
    partial class configInicial
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

                    b.Property<int>("ArtistaFK")
                        .HasColumnType("int");

                    b.Property<string>("FicheiroImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistaFK");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("Soundgenius.Models.Artista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FicheiroImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("ID");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("Soundgenius.Models.Faixas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FicheiroImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Faixas");
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
                    b.HasOne("Soundgenius.Models.Artista", "Artista")
                        .WithMany("Albuns")
                        .HasForeignKey("ArtistaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
