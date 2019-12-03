using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Estacao")]
    public class Estacao
    {
        public int EstacaoID { get; set; }

        public string EstacaoNome { get; set; }

        public string EstacaoLocalizacao { get; set; }

        public int EstacaoNumVeiculos { get; set; }

        //foreign key
        public IList<Veiculo> Veiculos { get; set; }
    }
}