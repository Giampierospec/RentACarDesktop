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
    public partial class VehiculosForm : MaterialForm
    {
        private int _userId;
        private VehiculosRepo _vehRepo;
        private UserRepo _userRepo;
        private int _vehiculoId = 0;

        public VehiculosForm(int id = 0)
        {
            _userId = id;
            InitializeComponent();
            _vehRepo = new VehiculosRepo();
            _userRepo = new UserRepo();
        }

        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            vehiculosTable.DataSource = _vehRepo.GetAllVehiculos();
            var user = _userRepo.GetUserById(_userId);
            if(user != null)
            {
                if(user.Id_Rol == 2)
                {
                    insertVehiculoBtn.Enabled = false;
                    editarVehiculoBtn.Enabled = false;
                }
            }
            
        }

        private void insertVehiculoBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            var insertVehiculoForm = new InsertVehiculoForm(_userId,0,"Insertar");
            Thread.Sleep(2000);
            Hide();
            insertVehiculoForm.ShowDialog();
            Close();
        }

        private void vehiculosTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _vehiculoId = int.Parse(vehiculosTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void editarVehiculoBtn_Click(object sender, EventArgs e)
        {
            if(_vehiculoId == 0)
            {
                MessageBox.Show("Escoja una fila para Editar sus propiedades");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                Thread.Sleep(2000);
                Hide();
                var insertVehiculosForm = new InsertVehiculoForm(_userId,_vehiculoId,"Editar");
                insertVehiculosForm.ShowDialog();
                Close();
            }
        }
    }
}
