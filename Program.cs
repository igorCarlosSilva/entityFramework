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


            var busca = from p in contexto.Produtos
                        orderby p.Nome
                        select p;


            foreach(var produto in busca)
            {
                Console.WriteLine(produto.Nome);
            }

            Console.ReadLine();

        }
    }
}
