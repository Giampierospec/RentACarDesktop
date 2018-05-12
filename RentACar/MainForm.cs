using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class MainForm : MaterialForm
    {
        private int _id;

        public MainForm(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private void vehiculoBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Utils.Validate.LockBtns(this);
            Thread.Sleep(2000);
            var vehiculosForm = new VehiculosForm(_id);
            Hide();
            vehiculosForm.ShowDialog();
            Close();
        }

        private void tpVehiculoBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Utils.Validate.LockBtns(this);
            Thread.Sleep(2000);
            var vehiculosForm = new TipoVehiculoForm(_id);
            Hide();
            vehiculosForm.ShowDialog();
            Close();
        }

        private void marcasBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Utils.Validate.LockBtns(this);
            Thread.Sleep(2000);
            var vehiculosForm = new MarcasForm(_id);
            Hide();
            vehiculosForm.ShowDialog();
            Close();
        }
    }
}
