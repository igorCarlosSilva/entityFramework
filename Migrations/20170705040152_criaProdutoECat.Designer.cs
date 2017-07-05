using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using alura;

namespace alura.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20170705040152_criaProdutoECat")]
    partial class criaProdutoECat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("alura.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("alura.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("alura.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("alura.Entidades.Produto", b =>
                {
                    b.HasOne("alura.Entidades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
        }
    }
}
