using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    public class UserRepo
    {
        private RentCarContext _db;

        public UserRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Funcion para devolver el usuario
        /// <paramref name="loginModel"/>
        /// </summary>
        /// <returns></returns>
        public Usuario GetUserByEmailAddress(LoginModel loginModel)
        {
            return _db.Usuarios.FirstOrDefault(x => x.Email == loginModel.Usuario && x.Pass == loginModel.Password);
        }
        /// <summary>
        /// Funcion para conseguir el usuario mediante el Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario GetUserById(int id) => _db.Usuarios.FirstOrDefault(x => x.Id == id);
        
    }
}
