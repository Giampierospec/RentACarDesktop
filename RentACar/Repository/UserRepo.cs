using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// Genera un mensaje si el email ya existe o no es un formato correcto
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string GenerateMessageIfUserExists(string email)
        {
            string msg = string.Empty;
            var user = _db.Usuarios.FirstOrDefault(x => x.Email.Trim().Contains(email.Trim()));
            if (user != null)
                msg += $"El Email {email} ya existe";
            if (!string.IsNullOrEmpty(Utils.Validate.CheckIfIsValidEmail(email)))
                msg += $"\n El email {email} no es un Email válido";
            return msg;
        }
                  //* Método o función para validar una cédula dominicana*
          
        /// <summary>
        /// Funcion para conseguir el usuario mediante el Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario GetUserById(int id) => _db.Usuarios.FirstOrDefault(x => x.Id == id);

    }
}
