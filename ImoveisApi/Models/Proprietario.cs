using System.ComponentModel.DataAnnotations;

namespace ImoveisApi.Models {
    public class Proprietario {

        [Key]
        public int Id_Proprietario { get; set; }
        public string Nome_Proprietario { get; set; }
        public string CPF_Proprietario { get; set; }
        public string Telefone_Proprietario { get; set; }
    }
}
