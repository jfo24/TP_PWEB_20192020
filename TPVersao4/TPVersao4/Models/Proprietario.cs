using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Proprietario")]
    public class Proprietario
    {
        [Required]
        public int ProprietarioID { get; set; }
        [DisplayName("Nome")]
        [Required]
        public string ProprietarioNome { get; set; }
        [DisplayName("Email")]
        public string ProprietarioEmail { get; set; }
        [DisplayName("NIB")]
        [Required]
        public int ProprietarioNIB { get; set; }
        [DisplayName("NIF")]
        [Required]
        public int ProprietarioNIF { get; set; }

        [DisplayName("Tipo")]
        [Required]
        public TipoProprietario TipoProprietario { get; set; }

        //foreign key
        public IList<Veiculo> Veiculos { get; set; }
        //foreign key
        public IList<Aluguer> Aluguers { get; set; }
    }
}