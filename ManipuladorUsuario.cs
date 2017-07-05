using alura.Entidades;
using System.Linq;

namespace alura
{
    class UsuarioDao
    {
        private EntidadesContext contexto;


        public UsuarioDao()
        {
            contexto = new EntidadesContext();
        }

        public void salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();

        }

        public void saveChanges()
        {
            contexto.SaveChanges();
        }

        public Usuario buscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void removeUsuario(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }

    }
}