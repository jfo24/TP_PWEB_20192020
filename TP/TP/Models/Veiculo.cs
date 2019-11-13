using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class Veiculo
    {
        public int veiculoID { get; set; }

        public int bateria { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public string VeiculoLocalizacao { get; set; }

        public string utilizadorID { get; set; }
    }
}