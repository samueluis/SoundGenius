﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soundgenius.Models;



namespace Soundgenius.Data
{
    public class SoundgeniusDB : DbContext
    {

        /// <summary>
        /// Construtor da classe
        /// serve para ligar esta classe à BD
        /// </summary>
        /// <param name="options"></param>
        public SoundgeniusDB(DbContextOptions<SoundgeniusDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            // insert DB seed
            modelBuilder.Entity<Faixas>().HasData(
               new Faixas { ID = 1, Titulo = "The man who sold the word", Genero = "Grunge", FicheiroImg = "MTV Unplugged" },
               new Faixas { ID = 2, Titulo = "About a girl", Genero = "Grunge", FicheiroImg = "Bleach" },
               new Faixas { ID = 3, Titulo = "come as you are", Genero = "Grunge", FicheiroImg = "Nevermind" },
               new Faixas { ID = 4, Titulo = "Everlong", Genero = "Rock Alternativo", FicheiroImg = "The color and the shape" },
               new Faixas { ID = 5, Titulo = "Best of you", Genero = "Rock Alternativo", FicheiroImg = "In Your Honor" },
               new Faixas { ID = 6, Titulo = "Pretender", Genero = "Rock Alternativo", FicheiroImg = "The color and the shape" },
               new Faixas { ID = 7, Titulo = "Fukk Sleep", Genero = "Hip hop", FicheiroImg = "Testing" },
               new Faixas { ID = 8, Titulo = "PMW", Genero = "Hip hop", FicheiroImg = "Long. Live. ASAP" },
               new Faixas { ID = 9, Titulo = "lVL", Genero = "Hip hop", FicheiroImg = "Long. Live. ASAP" },
               new Faixas { ID = 10, Titulo = "Wasted", Genero = "Hip hop", FicheiroImg = "goodbye & good riddance" }
                );

            // insert DB seed
            modelBuilder.Entity<Artista>().HasData(
               new Artista { ID = 1, Nome = "Nirvana", Sexo = "M", FicheiroImg = "Nirvana" },
               new Artista { ID = 2, Nome = "Foo Figthers", Sexo = "M", FicheiroImg = "Foo Figthers" },
               new Artista { ID = 3, Nome = "Asap Rocky", Sexo = "M", FicheiroImg = "Asap Rocky" },
               new Artista { ID = 4, Nome = "Juice wrld", Sexo = "M", FicheiroImg = "Juice wrld" }
                );

            // insert DB seed
            modelBuilder.Entity<Albuns>().HasData(
               new Albuns { ID = 1, Titulo = "MTV Unplugged", Genero = "Grunge", FicheiroImg = "MTV Unplugged", ArtistaFK = 1 },
               new Albuns { ID = 2, Titulo = "Bleach", Genero = "Grunge", FicheiroImg = "Bleach", ArtistaFK = 1 },
               new Albuns { ID = 3, Titulo = "Nevermind", Genero = "Grunge", FicheiroImg = "Nevermind", ArtistaFK = 1 },
               new Albuns { ID = 4, Titulo = "The color and the shape", Genero = "Rock Alternativo ", FicheiroImg = "The color and the shape", ArtistaFK = 2 },
               new Albuns { ID = 5, Titulo = " In Your Honor", Genero = "Rock Alternativo ", FicheiroImg = "In Your Honor", ArtistaFK = 2 },
               new Albuns { ID = 6, Titulo = "Foo Fighters Echoes, Silence, Patience & Grace", Genero = "Rock Alternativo ", FicheiroImg = "Foo Fighters Echoes, Silence, Patience & Grace", ArtistaFK = 2 },
               new Albuns { ID = 7, Titulo = "Testing", Genero = "Hip hop", FicheiroImg = "Testing", ArtistaFK = 3 },
               new Albuns { ID = 8, Titulo = "Long. Live. ASAP", Genero = "Hip hop", FicheiroImg = "Long. Live. ASAP", ArtistaFK = 3 },
               new Albuns { ID = 9, Titulo = "goodbye & good riddance", Genero = "Hip hop ", FicheiroImg = "goodbye & good riddance", ArtistaFK = 4 }
                );


            // insert DB seed
            modelBuilder.Entity<AlbumFaixas>().HasData(
               new AlbumFaixas { ID = 1, AlbumFK = 1, FaixaFK = 1 },
               new AlbumFaixas { ID = 2, AlbumFK = 2, FaixaFK = 2 },
               new AlbumFaixas { ID = 3, AlbumFK = 3, FaixaFK = 3 },
               new AlbumFaixas { ID = 4, AlbumFK = 4, FaixaFK = 4 },
               new AlbumFaixas { ID = 5, AlbumFK = 5, FaixaFK = 5 },
               new AlbumFaixas { ID = 6, AlbumFK = 6, FaixaFK = 6 },
               new AlbumFaixas { ID = 7, AlbumFK = 7, FaixaFK = 7 },
               new AlbumFaixas { ID = 8, AlbumFK = 8, FaixaFK = 8 },
               new AlbumFaixas { ID = 9, AlbumFK = 9, FaixaFK = 10 },
               new AlbumFaixas { ID = 10, AlbumFK = 7, FaixaFK = 9 }
                );
        }






        // adicionar as 'tabelas' à BD
        public virtual DbSet<AlbumFaixas> AlbumFaixas { get; set; }
        public virtual DbSet<Albuns> Albuns { get; set; }
        public virtual DbSet<Faixas> Faixas { get; set; }
        public virtual DbSet<Artista> Artista { get; set; }
    }
}




