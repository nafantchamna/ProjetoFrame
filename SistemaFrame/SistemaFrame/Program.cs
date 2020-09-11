using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFrame
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ClienteContext())
            {
                var quantidade_Clientes = context.Clientes.Count();
                context.Clientes.Add(new Cliente() { Nome = "Fatinha", Telefone = "11987949330" });

                context.Clientes.Add(new Cliente() { Nome = "Fatinha", Telefone = "11987949330", CPF = "23660629820" });
                context.Produtos.Add(new Produto() { Nome = "Computador Dell", Descricao = "Compuatdor marca Dell 8th" });
                context.SaveChanges();
            }
        }
    }
}
