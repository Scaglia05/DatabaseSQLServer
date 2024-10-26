using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi.Models {
    public class Pagamento {
        [Key]
        public int Id_Pagamento { get; set; }
        public DateTime Data_Pagamento { get; set; }
        public decimal Valor_Pagamento { get; set; }

        [ForeignKey(nameof(Contrato))]
        public Contrato  Id_Contrato { get; set; }
    }
}
