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
    public partial class TipoCombustibleForm : MaterialForm
    {
        private int _userId;
        private TCRepo _tcRepo;
        private UserRepo _userRepo;
        private int _tcId = 0;
        public TipoCombustibleForm(int userId = 0)
        {
            _userId = userId;
            _tcRepo = new TCRepo();
            _userRepo = new UserRepo();
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void TipoCombustibleForm_Load(object sender, EventArgs e)
        {
            TCTable.DataSource = _tcRepo.GetAllTipoCombustible();
            var user = _userRepo.GetUserById(_userId);
            if(user.Id_Rol== 2)
            {
                Utils.Validate.LockBtns(this);
            }
        }

        private void TCTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _tcId = int.Parse(TCTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void insertTcBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ModifyTipoCombustible(_userId, 0, "Insertar"));
        }

        private void editarTcBtn_Click(object sender, EventArgs e)
        {
            if(_tcId == 0)
            {
                MessageBox.Show("Escoja una fila para editar");

            }
            else
            {
                Utils.Validate.LockBtns(this);
                Utils.Returning.ReturnToPreviousForm(this, new ModifyTipoCombustible(_userId, _tcId, "Editar"));
            }
        }

        private void tcText_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
           TCTable.DataSource =  _tcRepo.Filter(new Context.TipoCombustible()
            {
                Descripcion = tcText.Text.Trim()
            });
        }
    }
}
