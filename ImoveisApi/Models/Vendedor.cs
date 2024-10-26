using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi.Models {
    public class Vendedor {
        [Key]
        public int Id { get; set; }
        public string Nome_Vendedor { get; set; }
        public string CRECI_Vendedor { get; set; }
        public int Telefone_Vendedor { get; set; }
        public int Email_Vendedor { get; set; }
    }
}
