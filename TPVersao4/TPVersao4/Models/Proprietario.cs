using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Proprietario")]
    public class Proprietario
    {
        public int ProprietarioID { get; set; }

        public string ProprietarioNome { get; set; }

        public string ProprietarioEmail { get; set; }

        public int ProprietarioNIB { get; set; }

        public int ProprietarioNIF { get; set; }

        public TipoProprietario TipoProprietario { get; set; }

        //foreign key
        public IList<Veiculo> Veiculos { get; set; }
        //foreign key
        public IList<Aluguer> Aluguers { get; set; }
    }
}