using System.ComponentModel.DataAnnotations;

namespace CP1_.NET__refeito._.Models
{
    public class TipoQuarto
    {

        [Key]
        public int TipoQuartoID { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
