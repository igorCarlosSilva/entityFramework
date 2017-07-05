using alura.Entidades;
using Microsoft.Data.Entity;
using System.Configuration;

namespace alura
{
    public class EntidadesContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["alura.Properties.Settings.aluraCursoEntityConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);

            base.OnConfiguring(optionsBuilder);
        }

    }
}