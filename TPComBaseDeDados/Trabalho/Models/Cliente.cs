using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class Cliente
    {
        [Index(IsUnique = true)]
        public int ID { get; set; }

        public string Nome { get; set; }

        //public string Morada { get; set; }

        public string NIF { get; set; }

        public string NIB { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

        //public int Conta { get; set; }
    }
}