using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class Proprietario
    {
        [Index(IsUnique = true)]
        public int ProprietarioID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int NIB { get; set; }

        public int NIF { get; set; }

        //foreign key
        public Cliente Cliente { get; set; }
        //foreign key
        public Veiculo Veiculo { get; set; }
    }
}