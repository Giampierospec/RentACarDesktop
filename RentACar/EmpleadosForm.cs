using MaterialSkin.Controls;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class EmpleadosForm : MaterialForm
    {
        private int _empleadoId = 0;
        private int _userId;
        private EmpleadosRepo _empRepo;

        public EmpleadosForm(int userId = 0)
        {
            _userId = userId;
            _empRepo = new EmpleadosRepo();
            InitializeComponent();
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            var user = _empRepo.GetUserById(_userId);
            if(user.Id_Rol != 1)
            {
                Utils.Validate.LockBtns(this);
            }
            EmpleadoTable.DataSource = _empRepo.GetAllEmpleados();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void insertEmpleadoBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ModifyEmpleados(_userId, 0, "Insertar"));
        }

        private void EmpleadoTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _empleadoId = int.Parse(EmpleadoTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void editarEmpleadoBtn_Click(object sender, EventArgs e)
        {
            if(_empleadoId == 0)
            {
                MessageBox.Show("Escoja una fila para editar");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                Utils.Returning.ReturnToPreviousForm(this, new ModifyEmpleados(_userId, _empleadoId, "Insertar"));
            }
        }
    }
}
