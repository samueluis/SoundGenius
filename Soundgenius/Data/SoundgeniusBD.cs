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


        // adicionar as 'tabelas' à BD
        public DbSet<AlbumFaixas> AlbumFaixas { get; set; }
        public DbSet<Albuns> Albuns { get; set; }
        public DbSet<Faixas> Faixas { get; set; }
        public DbSet<Utilizador> Utilizador { get; set; }
    }
}




