﻿using RentACar.Models;
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
        private static Regex numberValidation = new Regex(@"^\d+$");
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
                    || ctrl.GetType() == typeof(DateTimePicker))
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
        public static string IsANumber(Control str)
        {
            string msg = string.Empty;
            if (!numberValidation.IsMatch(str.Text))
                msg = $"{str.Name} no es un numero Intente Denuevo";
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
        /// <summary>
        /// Bloquea los botones
        /// </summary>
        /// <param name="ctrls"></param>
        public static void LockBtns(Control ctrls)
        {
            foreach (Control ctrl in ctrls.Controls)
            {
                if (ctrl.GetType() == typeof(Button) || ctrl.GetType() == typeof(MaterialSkin.Controls.MaterialFlatButton))
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
