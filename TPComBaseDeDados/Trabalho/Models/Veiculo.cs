using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class Veiculo
    {
        [Index(IsUnique = true)]
        public int VeiculoID { get; set; }

        public int Bateria { get; set; }

        public string Localizacao { get; set; }

        //foreign key // reference navigation property of type Cliente
        //public Cliente Cliente { get; set; }
    }
}