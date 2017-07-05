using alura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alura
{
    class Program
    {
        static void Main(string[] args)
        {


            EntidadesContext contexto = new EntidadesContext();
            Categoria c = new Categoria() {

                Nome = "Informática"

            };


            contexto.Categorias.Add(c);
            contexto.SaveChanges();

            Produto p = new Produto()
            {

                Nome = "Mouse",
                Preco = 20,
                Categoria = c

            };


            contexto.Produtos.Add(p);
            contexto.SaveChanges();


        }
    }
}
