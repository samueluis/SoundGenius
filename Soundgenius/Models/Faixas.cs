using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Soundgenius.Models
{
    public class Faixas
    {
        public Faixas()
        {
            AlbumFaixas = new HashSet<AlbumFaixas>();
        }

        [Key]
        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public string FicheiroImg { get; set; }

        //---------------------------------------------------------------------------
        public ICollection<AlbumFaixas> AlbumFaixas { get; set; }
        //adicinoar comentarios 
    }
}
