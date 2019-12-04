using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Aluguer")]
    public class Aluguer
    {
        [DisplayName("ID Aluguer")]
        [Required]
        public int AluguerId { get; set; }
        [Required]
        public Proprietario Proprietario { get; set; }
        [DisplayName("ID Proprietario")]
        [Required]
        public int ProprietarioID { get; set; }
        [Required]
        public Veiculo Veiculo { get; set; }
        [DisplayName("ID Veiculo")]
        [Required]
        public int VeiculoID { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        [DisplayName("ID Cliente")]
        [Required]
        public int ClienteID { get; set; }

    }
}