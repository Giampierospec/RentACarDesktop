using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Utils
{
    public static class Returning
    {
        /// <summary>
        /// Retorna al login desde un form origen
        /// </summary>
        /// <param name="frm"></param>
        public static void ReturnToLogin(MaterialForm frm)
        {
            frm.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            frm.Hide();
            var mainLogin = new LoginForm();
            mainLogin.ShowDialog();
            frm.Close();
        }
        /// <summary>
        /// LLeva desde un Form origen hasta un form destino
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="FormTo"></param>
        public static void ReturnToPreviousForm(MaterialForm frm, MaterialForm FormTo)
        {
            frm.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            frm.Hide();
            var mainLogin = FormTo;
            mainLogin.ShowDialog();
            frm.Close();
        }
    }
}
