using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soundgenius.Models
{
    public class Albuns
    {
        public Albuns()
        {
            AlbumFaixas = new HashSet<AlbumFaixas>();
        }

        [Key]
        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public string FicheiroImg { get; set; }

        // FK para a 'tabela' dos Faixas
        [ForeignKey("Faixas")]
        public int FaixasFK { get; set; }
        public virtual Faixas Faixas { get; set; }

        //------------------------------------------------------------------------------
        public ICollection<AlbumFaixas> AlbumFaixas { get; set; }
    }
}
