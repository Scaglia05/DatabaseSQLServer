using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using static ImoveisApi.Models.Enums;

namespace ImoveisApi.Models {
    public class Imovel {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Proprietario))]
        public Proprietario Id_Proprietario { get; set; }
        public string Endereco_Imovel { get; set; }
        [Precision(10,3)]
        public decimal AreaTotal_Imovel { get; set; }
        public Tipo_Imovel Tipo { get; set; }
        public Status_Imovel Status{  get; set; }
        public decimal ValorTotal { get; set; }
    }
}
