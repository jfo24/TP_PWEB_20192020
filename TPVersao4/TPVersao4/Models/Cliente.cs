using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        
        [Required]
        public int ClienteId { get; set; }
        [DisplayName("Nome")]
        [Required]
        public string ClienteNome { get; set; }
        [DisplayName("Morada")]
        [Required]
        public string ClienteMorada { get; set; }
        [DisplayName("NIF")]
        [Required]
        public string ClienteNIF { get; set; }
        [DisplayName("NIB")]
        [Required]
        public string ClienteNIB { get; set; }
        [DisplayName("Email")]
        public string ClienteEmail { get; set; }
        [DisplayName("Telefone")]
        public int ClienteTelefone { get; set; }

        public IList<Aluguer> Aluguers { get; set; }

    }
}