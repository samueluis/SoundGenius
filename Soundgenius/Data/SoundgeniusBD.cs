using System;
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
               new Faixas { ID = 1, Titulo = "The man who sold the word", Genero = "Grunge", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 2, Titulo = "About a girl", Genero = "Grunge", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 3, Titulo = "you know you are right", Genero = "Grunge", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 4, Titulo = "Everlong", Genero = "Rock Alternativo", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 5, Titulo = "Best of you", Genero = "Rock Alternativo", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 6, Titulo = "Pretender", Genero = "Rock Alternativo", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 7, Titulo = "Peso", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 8, Titulo = "PMW", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 9, Titulo = "lVL", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" },
               new Faixas { ID = 10,Titulo = "Bandid", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" }
                );
        

        // insert DB seed
        modelBuilder.Entity<Albuns>().HasData(
               new Albuns { ID = 1, Titulo = "The man who sold the word", Genero = "Grunge", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 2, Titulo = "About a girl", Genero = "Grunge", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 3, Titulo = "you know you are right", Genero = "Grunge", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 4, Titulo = "Everlong", Genero = "Rock Alternativo", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 5, Titulo = "Best of you", Genero = "Rock Alternativo", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 6, Titulo = "Pretender", Genero = "Rock Alternativo", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 7, Titulo = "Peso", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 8, Titulo = "PMW", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 9, Titulo = "lVL", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" },
               new Albuns { ID = 10,Titulo = "Bandid", Genero = "Hip hop", FicheiroImg = "dsfhshdfs" }
                );
        }






        // adicionar as 'tabelas' à BD
        public DbSet<AlbumFaixas> AlbumFaixas { get; set; }
        public DbSet<Albuns> Albuns { get; set; }
        public DbSet<Faixas> Faixas { get; set; }
        public DbSet<Artista> Artistas { get; set; }
    }
}




