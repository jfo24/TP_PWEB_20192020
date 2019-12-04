using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [DisplayName("ID")]
        [Required]
        public int VeiculoID { get; set; }
        [DisplayName("Tipo")]
        [Required]
        public TipoVeiculo TipoVeiculo { get; set; }
        [DisplayName("Preco")]
        [Required]
        public int VeiculoPreco { get; set; }
        [DisplayName("Bateria")]
        [Required]
        public int VeiculoBateria { get; set; }

        public Estacao Estacao { get; set; }

        public Proprietario Proprietario { get; set; }
    }
}