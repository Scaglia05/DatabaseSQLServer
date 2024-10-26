using System.ComponentModel;

namespace ImoveisApi.Models {
    public class Enums {
        public enum Tipo_Imovel {

            [Description("Casa")]
            Casa = 1,

            [Description("Apartamento")]
            Apartamento = 2,

            //[Description("Ficha de Reavaliação")]
            //FichaReavaliacao = 3,
        } 
        public enum Status_Imovel {

            [Description("Disponível")]
            Disponivel = 1,

            [Description("Indisponível")]
            Indisponível = 2,

            //[Description("Ficha de Reavaliação")]
            //FichaReavaliacao = 3,
        }
    }
}
