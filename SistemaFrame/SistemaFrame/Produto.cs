using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFrame
{
    [Table("Produtos")]
    public class Produto
    {
      
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
     
    }
}
