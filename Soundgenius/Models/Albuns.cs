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

        public string Autor { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public string FicheiroImg { get; set; }

        // FK ---> Utilizador
        [ForeignKey(nameof(Utilizador))] // nameof() -> devolve a designação (como string) do objeto que é colocado como parâmetro
        public int UtilizadorFK { get; set; }
        public Utilizador Utilizador { get; set; }

        //------------------------------------------------------------------------------
        public ICollection<AlbumFaixas> AlbumFaixas { get; set; }
    }
}
