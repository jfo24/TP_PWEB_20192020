using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class Empresa
    {
        [Index(IsUnique = true)]
        public int EmpresaID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int NIB { get; set; }

        public int NIPC { get; set; }

        //foreign key
        public Cliente Cliente { get; set; }
        //foreign key
        public Veiculo Veiculo { get; set; }
    }
}