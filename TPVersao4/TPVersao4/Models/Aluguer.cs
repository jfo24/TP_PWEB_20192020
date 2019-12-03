using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Aluguer")]
    public class Aluguer
    {
        public int AluguerId { get; set; }

        public Proprietario Proprietario { get; set; }

        public int ProprietarioID { get; set; }

        public Veiculo Veiculo { get; set; }

        public int VeiculoID { get; set; }

        public Cliente Cliente { get; set; }

        public int ClienteID { get; set; }

    }
}