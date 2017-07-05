using alura.Entidades;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace alura
{
    public class ProdutoDAO
    {
        private EntidadesContext contexto;

        public ProdutoDAO(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> buscaPorNomePrecoNomeCategoria(string nome, decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos select p;

            if (!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
            }

            if(preco > 0.0m)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList();
        }
    }
}