using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMVC.Models
{
    public class MVCContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}