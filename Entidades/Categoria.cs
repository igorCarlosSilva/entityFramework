using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace alura.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public IList<Produto> produtos { get; set; }

    }
}