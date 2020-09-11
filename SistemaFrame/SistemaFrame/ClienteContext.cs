﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFrame
{
  public  class ClienteContext: DbContext
    {
       public DbSet<Cliente> Clientes { get; set; }
       public DbSet<Produto> Produtos { get; set; }
    }
}
