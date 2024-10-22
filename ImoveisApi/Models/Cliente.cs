using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ImoveisApi.Models {
    public class Cliente {

        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
