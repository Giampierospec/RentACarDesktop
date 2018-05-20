using MaterialSkin.Controls;
using RentACar.Models;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Utils
{
    public static class Validate
    {
        private static Regex emailValidation = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");
        private static Regex numberValidation = new Regex(@"^[0-9.]+$");
        /// <summary>
        /// Genera Un mensaje de error si el control esta vacio
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static string GenerateErrorMessage(Control control)
        {
            string validateMsg = string.Empty;
            string finalString = string.Empty;
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox))
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                        validateMsg += $"{ctrl.Name}\n";

                }
            }
            if (!string.IsNullOrEmpty(validateMsg))
                finalString = $"Siguientes campos están vacíos \n {validateMsg}";
            return finalString;
        }
        /// <summary>
        /// Revisa si el email es valido
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string CheckIfIsValidEmail(string email)
        {
            string msg = string.Empty;

            if (!emailValidation.IsMatch(email))
                msg = $"el email {email} No es válido";
            return msg;
        }
        /// <summary>
        /// Lockea Controles
        /// <paramref name="ctrl"/>
        /// </summary>
        public static void LockControls(Control ctrls)
        {
            foreach (Control ctrl in ctrls.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox)
                    || ctrl.GetType() == typeof(DateTimePicker)
                    || ctrl.GetType() == typeof(CheckBox)
                    || ctrl.GetType() == typeof(MaterialCheckBox))
                {
                    ctrl.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Busca si el texto es un numero
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string IsANumber(params Control[] strs)
        {
            string msg = string.Empty;
            foreach (var  str in strs)
            {
                if (!numberValidation.IsMatch(str.Text))
                    msg += $"{str.Name} no es un numero\n";
            }
            if (!string.IsNullOrEmpty(msg))
                msg += "Intente denuevo";
            return msg;
        }
        /// <summary>
        ///Desbloquea Controles
        /// <paramref name="ctrl"/>
        /// </summary>
        public static void UnLockControls(Control ctrls)
        {
            foreach (Control ctrl in ctrls.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox)
                        || ctrl.GetType() == typeof(DateTimePicker))
                {
                    ctrl.Enabled = true;
                }
            }
        }
        public static  bool ValidaCedula(string cedula)
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
                            digitoImpar = digito * 2;
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
        /// Bloquea los botones
        /// </summary>
        /// <param name="ctrls"></param>
        public static void LockBtns(Control ctrls)
        {
            foreach (Control ctrl in ctrls.Controls)
            {
                if (ctrl.GetType() == typeof(Button) || ctrl.GetType() == typeof(MaterialFlatButton))
                {
                    ctrl.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Activa los botones
        /// </summary>
        /// <param name="ctrls"></param>
        public static void EnableBtns(Control ctrls)
        {
            foreach (Control ctrl in ctrls.Controls)
            {
                if (ctrl.GetType() == typeof(Button) || ctrl.GetType() == typeof(MaterialSkin.Controls.MaterialFlatButton))
                {
                    ctrl.Enabled = true;
                }
            }
        }
    }
}
