using RentACar.Models;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Utils
{
    public static class Validate
    {
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
                if(ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox))
                {
                    if(string.IsNullOrEmpty(ctrl.Text))
                        validateMsg += $"{ctrl.Name}\n";

                }
            }
            if (!string.IsNullOrEmpty(validateMsg))
                finalString = $"Siguientes campos están vacíos \n {validateMsg}";
            return finalString;
        }
    }
}
