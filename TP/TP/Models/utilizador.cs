using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class utilizador
    {
        public int utilizadorID { get; set; }

        public string Nome { get; set; }

        public string Morada { get; set; }

        public string UserEmail { get; set; }

        public int NIB { get; set; }
    }
}