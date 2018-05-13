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
        public static void ReturnToLogin(MaterialForm frm)
        {
            frm.Cursor = Cursors.WaitCursor;
            Thread.Sleep(2000);
            frm.Hide();
            var mainLogin = new LoginForm();
            mainLogin.ShowDialog();
            frm.Close();
        }
        public static void ReturnToPreviousForm(MaterialForm frm, MaterialForm FormTo)
        {
            frm.Cursor = Cursors.WaitCursor;
            Thread.Sleep(2000);
            frm.Hide();
            var mainLogin = FormTo;
            mainLogin.ShowDialog();
            frm.Close();
        }
    }
}
