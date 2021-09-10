using HS_BANK_ENTERPRISE.Database;
using HS_BANK_ENTERPRISE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Services.Usuarios
{
    public class UsuariosService : IUsuariosService
    {
        private readonly Context _Context;
        public UsuariosService(Context context)
        {
            _Context = context;

        }
        public Usuario Create(Usuario usuario)
        {
            _Context.Usuario.Add(usuario);

            var salvo = _Context.SaveChanges();

            if(salvo > 0)
            {
                return usuario;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var User = GetByID(id);
            if(User == null)
            {
                return false;
            }

            _Context.Usuario.Remove(User);
            _Context.SaveChanges();

            return true;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _Context.Usuario.ToList();
        }

        public Usuario GetByID(int id)
        {
            return _Context.Usuario.Where(x => x.idUsuario == id).FirstOrDefault();
        }

        public Usuario Update(Usuario usuario)
        {
            
            _Context.Usuario.Update(usuario);
            _Context.SaveChanges();

            return usuario;
        }
    }
}
