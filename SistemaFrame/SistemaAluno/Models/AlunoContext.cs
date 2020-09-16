using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaAluno.Models
{
    public class AlunoContext: DbContext
    {
       public DbSet<Pessoa> Pessoas { get; set; }
    }
}