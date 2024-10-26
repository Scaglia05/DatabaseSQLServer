using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ImoveisApi.Models {
    public class Cliente {

        [Key]
        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Email")]
        public string Email_Cliente{ get; set; }
    }
}
