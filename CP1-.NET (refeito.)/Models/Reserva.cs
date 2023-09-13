using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP1_.NET__refeito._.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaID { get; set; }

        [Required]
        public int HospedeID { get; set; }

        [Required]
        public int QuartoID { get; set; }

        [Required]
        public DateTime DataEntrada { get; set; }

        [Required]
        public DateTime DataSaida { get; set; }

        [Required]
        public decimal ValorTotal { get; set; }

        [ForeignKey("HospedeID")]
        public Hospede Hospede { get; set; }

    }
}
