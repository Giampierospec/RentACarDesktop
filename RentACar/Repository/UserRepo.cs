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
        /// Funcion para revisar si el usuario existe
        /// </summary>
        /// <returns></returns>
        public bool CheckIfUserExists(LoginModel loginModel)
        {
            return _db.Usuarios.Any(x => x.Email == loginModel.Usuario && x.Pass == loginModel.Password);
        }
    }
}
