using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soundgenius.Models
{
    public class Utilizador
    {

        public Utilizador()
        {
            ListaAlbum = new HashSet<Albuns>();
        }

        [Key]
        public int ID { get; set; }

        //public string Tipo { get; set; }

        public string Email { get; set; }

        public string Autor { get; set; }

        public string MusicaPerf { get; set; }

        public string ContaFacebook { get; set; }

        public DateTime Data { get; set; }

        //----------------------------------------------
        public ICollection<Albuns> ListaAlbum { get; set; }
    }
}
