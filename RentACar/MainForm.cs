using MaterialSkin.Controls;
using RentACar.Repository;
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
        private UserRepo _userRepo;

        public MainForm(int id = 0)
        {
            _id = id;
            _userRepo = new UserRepo();
            InitializeComponent();
        }

        private void vehiculoBtn_Click(object sender, EventArgs e)
        {
           
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this,new VehiculosForm(_id));
          
        }

        private void tpVehiculoBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new TipoVehiculoForm(_id));
        }

        private void marcasBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new MarcasForm(_id));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void modelosBtn_Click(object sender, EventArgs e)
        {

            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ModelosForm(_id));

        }

        private void tipoCombustibleBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new TipoCombustibleForm(_id));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var user = _userRepo.GetUserById(_id);
            if(user.Id_Rol == 1)
            {
                empleadosBtn.Visible = true;
                clientesBtn.Visible = true;
            }
        }

        private void empleadosBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new EmpleadosForm(_id));
        }

        private void clientesBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ClientesForm(_id));
        }
    }
}
