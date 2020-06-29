﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Soundgenius.Data;

namespace Soundgenius.Migrations
{
    [DbContext(typeof(SoundgeniusDB))]
    partial class SoundgeniusDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AlbumFK = 1,
                            FaixaFK = 1
                        },
                        new
                        {
                            ID = 2,
                            AlbumFK = 2,
                            FaixaFK = 2
                        },
                        new
                        {
                            ID = 3,
                            AlbumFK = 3,
                            FaixaFK = 3
                        },
                        new
                        {
                            ID = 4,
                            AlbumFK = 4,
                            FaixaFK = 4
                        },
                        new
                        {
                            ID = 5,
                            AlbumFK = 5,
                            FaixaFK = 5
                        },
                        new
                        {
                            ID = 6,
                            AlbumFK = 6,
                            FaixaFK = 6
                        },
                        new
                        {
                            ID = 7,
                            AlbumFK = 7,
                            FaixaFK = 7
                        },
                        new
                        {
                            ID = 8,
                            AlbumFK = 8,
                            FaixaFK = 8
                        },
                        new
                        {
                            ID = 9,
                            AlbumFK = 9,
                            FaixaFK = 10
                        },
                        new
                        {
                            ID = 10,
                            AlbumFK = 7,
                            FaixaFK = 9
                        });
                });

            modelBuilder.Entity("Soundgenius.Models.Albuns", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtistaID")
                        .HasColumnType("int");

                    b.Property<int>("FaixasFK")
                        .HasColumnType("int");

                    b.Property<string>("FicheiroImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistaID");

                    b.HasIndex("FaixasFK");

                    b.ToTable("Albuns");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FaixasFK = 1,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Grunge",
                            Titulo = "MTV Unplugged"
                        },
                        new
                        {
                            ID = 2,
                            FaixasFK = 2,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Grunge",
                            Titulo = "Bleach"
                        },
                        new
                        {
                            ID = 3,
                            FaixasFK = 3,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Grunge",
                            Titulo = "Nevermind"
                        },
                        new
                        {
                            ID = 4,
                            FaixasFK = 4,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Rock Alternativo ",
                            Titulo = "The color and the shape"
                        },
                        new
                        {
                            ID = 5,
                            FaixasFK = 5,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Rock Alternativo ",
                            Titulo = " In Your Honor"
                        },
                        new
                        {
                            ID = 6,
                            FaixasFK = 6,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Rock Alternativo ",
                            Titulo = "Foo Fighters Echoes, Silence, Patience & Grace"
                        },
                        new
                        {
                            ID = 7,
                            FaixasFK = 7,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop",
                            Titulo = "Testing"
                        },
                        new
                        {
                            ID = 8,
                            FaixasFK = 8,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop",
                            Titulo = "Long. Live. ASAP"
                        },
                        new
                        {
                            ID = 9,
                            FaixasFK = 10,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop ",
                            Titulo = "goodbye & good riddance"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FicheiroImg = "dsfhshdfs",
                            Nome = "Nirvana",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 2,
                            FicheiroImg = "dsfhshdfs",
                            Nome = "Foo Figthers",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 3,
                            FicheiroImg = "dsfhshdfs",
                            Nome = "Asap Rocky",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 4,
                            FicheiroImg = "dsfhshdfs",
                            Nome = "Juice wrld",
                            Sexo = "M"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Grunge",
                            Titulo = "The man who sold the word"
                        },
                        new
                        {
                            ID = 2,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Grunge",
                            Titulo = "About a girl"
                        },
                        new
                        {
                            ID = 3,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Grunge",
                            Titulo = "come as you are"
                        },
                        new
                        {
                            ID = 4,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Rock Alternativo",
                            Titulo = "Everlong"
                        },
                        new
                        {
                            ID = 5,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Rock Alternativo",
                            Titulo = "Best of you"
                        },
                        new
                        {
                            ID = 6,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Rock Alternativo",
                            Titulo = "Pretender"
                        },
                        new
                        {
                            ID = 7,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop",
                            Titulo = "Fukk Sleep"
                        },
                        new
                        {
                            ID = 8,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop",
                            Titulo = "PMW"
                        },
                        new
                        {
                            ID = 9,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop",
                            Titulo = "lVL"
                        },
                        new
                        {
                            ID = 10,
                            FicheiroImg = "dsfhshdfs",
                            Genero = "Hip hop",
                            Titulo = "Wasted"
                        });
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
                    b.HasOne("Soundgenius.Models.Artista", null)
                        .WithMany("ListaAlbuns")
                        .HasForeignKey("ArtistaID");

                    b.HasOne("Soundgenius.Models.Faixas", "Faixas")
                        .WithMany()
                        .HasForeignKey("FaixasFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
