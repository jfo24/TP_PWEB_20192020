using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string ClienteNome { get; set; }

        public string ClienteMorada { get; set; }

        public string ClienteNIF { get; set; }

        public string ClienteNIB { get; set; }

        public string ClienteEmail { get; set; }

        public int ClienteTelefone { get; set; }

        public IList<Aluguer> Aluguers { get; set; }

    }
}