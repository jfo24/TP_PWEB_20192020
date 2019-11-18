using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class Estacao
    {
        public int ID { get; set; }

        public string Localizacao { get; set; }

        public int NumVeiculos { get; set; }

        public TipoVeiculo Tipo { get; set; }
    }
}