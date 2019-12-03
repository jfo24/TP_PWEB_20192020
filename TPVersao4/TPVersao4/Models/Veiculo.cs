using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        public int VeiculoID { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public int VeiculoPreco { get; set; }

        public int VeiculoBateria { get; set; }


        //foreign key // reference navigation property of type Cliente
        public Estacao Estacao { get; set; }
        public Proprietario Proprietario { get; set; }
    }
}