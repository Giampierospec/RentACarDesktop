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
            if (!Utils.Validate.CheckIfIsValidEmail(email))
                msg += $"\n El email {email} no es un Email válido";
            return msg;
        }
                  //* Método o función para validar una cédula dominicana*
          public bool ValidaCedula(string cedula)
          {
              //Declaración de variables a nivel de método o función.
              int verificador = 0;
              int digito = 0;
              int digitoVerificador = 0;
              int digitoImpar = 0;
              int sumaPar = 0;
              int sumaImpar = 0;
              int longitud = Convert.ToInt32(cedula.Length);
              /*Control de errores en el código*/
              try
              {
                  //verificamos que la longitud del parametro sea igual a 11
                  if (longitud == 11)
                  {
                   digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                     //recorremos en un ciclo for cada dígito de la cédula
                     for (int i = 9; i >= 0; i--)
                     {
                         //si el digito no es par multiplicamos por 2
                         digito = Convert.ToInt32(cedula.Substring(i, 1));
                         if ((i % 2) != 0)
                         {
                             digitoImpar = digito* 2;
                             //si el digito obtenido es mayor a 10, restamos 9
                             if (digitoImpar >= 10)
                             {
                                 digitoImpar = digitoImpar - 9;
                             }
                             sumaImpar = sumaImpar + digitoImpar;
                         }
                         /*En los demás casos sumamos el dígito y lo aculamos 
                          en la variable */
                          else
                          {
                              sumaPar = sumaPar + digito;
                          }
                      }
                     /*Obtenemos el verificador restandole a 10 el modulo 10 
                     de la suma total de los dígitos*/
                     verificador = 10 - ((sumaPar + sumaImpar) % 10);
                   /*si el verificador es igual a 10 y el dígito verificador
                     es igual a cero o el verificador y el dígito verificador 
                     son iguales retorna verdadero*/
                if (((verificador == 10) && (digitoVerificador == 0))
                     || (verificador == digitoVerificador))
                     {
                          return true;
                     }
                 }
                 else
                {
                 MessageBox.Show("La cédula debe contener once(11) digitos");
                }
             }
            catch
             {
               MessageBox.Show("No se pudo validar la cédula");
            }
             return false;
        }
        /// <summary>
        /// Funcion para conseguir el usuario mediante el Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario GetUserById(int id) => _db.Usuarios.FirstOrDefault(x => x.Id == id);

    }
}
