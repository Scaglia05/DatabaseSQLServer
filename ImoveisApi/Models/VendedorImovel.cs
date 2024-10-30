using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi.Models {
    public class VendedorImovel {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Vendedor))]
        public Vendedor Vendedor_Id { get; set; }

        [ForeignKey(nameof(Imovel))]
        public Imovel Imovel_Id { get; set; }

    }
}
