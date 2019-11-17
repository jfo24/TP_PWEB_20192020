using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class Veiculo
    {
        public int VeiculoID { get; set; }

        public int Bateria { get; set; }

        public TipoVeiculo Tipo { get; set; }

        public string Localizacao { get; set; }

        public string UtilizadorID { get; set; }
    }
}