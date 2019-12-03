using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPVersao4.Models
{
    public class GreenChargeContext : DbContext
    {
        public GreenChargeContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Aluguer> Aluguers { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Estacao> Estacoes { get; set; }

       

    }
}