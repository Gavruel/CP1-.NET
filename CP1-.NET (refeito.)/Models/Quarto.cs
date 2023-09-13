using System.ComponentModel.DataAnnotations;

namespace CP1_.NET__refeito._.Models
{
    public class Quarto
    {

        [Key]
        public int QuartoID { get; set; }

        [Required]
        public string NumeroQuarto { get; set; }

        [Required]
        public decimal PrecoPorNoite { get; set; }

        [Required]
        public int TipoQuartoID { get; set; }
    }
}
