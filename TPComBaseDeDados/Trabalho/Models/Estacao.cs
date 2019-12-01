using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class Estacao
    {
        [Index(IsUnique = true)]
        public int EstacaoID { get; set; }

        public string Localizacao { get; set; }

        public int NumVeiculos { get; set; }

        //foreign key
        public Veiculo Veiculo { get; set; }
    }
}