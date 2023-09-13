using System.ComponentModel.DataAnnotations;

namespace CP1_.NET__refeito._.Models
{
    public class Pagamento
    {

        [Key]
        public int PagamentoID { get; set; }

        [Required]
        public int ReservaID { get; set; }

        [Required]
        public DateTime DataPagamento { get; set; }

        [Required]
        public decimal DataPagamentoName { get; set; }

    }
}
