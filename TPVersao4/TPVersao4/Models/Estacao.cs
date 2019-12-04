using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Estacao")]
    public class Estacao
    {
        [Required]
        public int EstacaoID { get; set; }
        [DisplayName("Nome")]
        [Required]
        public string EstacaoNome { get; set; }
        [DisplayName("Localização")]
        [Required]
        public string EstacaoLocalizacao { get; set; }
        [DisplayName("Número de Veículos")]
        [Required]
        public int EstacaoNumVeiculos { get; set; }

        //foreign key
        public IList<Veiculo> Veiculos { get; set; }
    }
}