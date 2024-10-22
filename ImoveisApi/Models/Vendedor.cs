using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi.Models {
    public class Vendedor {


        public int Id { get; set; }

        [ForeignKey(nameof(Cliente))]
        public int Cliente_Id { get; set; }
    }
}
