using HS_BANK_ENTERPRISE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Services.Usuarios
{
    public interface IUsuariosService
    {
        public IEnumerable<Usuario> GetAll();
        public Usuario GetByID(int id);
        public Usuario Create(Usuario usuario);
        public Usuario Update(Usuario usuario);
        public bool Delete(int id);
    }
}
