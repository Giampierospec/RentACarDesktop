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
    public partial class VehiculosForm : MaterialForm
    {
        private int _userId;
        private VehiculosRepo _vehRepo;
        private int _vehiculoId = 0;

        public VehiculosForm(int id = 0)
        {
            _userId = 0;
            InitializeComponent();
            _vehRepo = new VehiculosRepo();
        }

        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            vehiculosTable.DataSource = _vehRepo.GetAllVehiculos();
            
        }

        private void insertVehiculoBtn_Click(object sender, EventArgs e)
        {
            var insertVehiculoForm = new InsertVehiculoForm(_userId);
            Hide();
            insertVehiculoBtn.Enabled = false;
            insertVehiculoForm.ShowDialog();
            Close();
        }

        private void vehiculosTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _vehiculoId = int.Parse(vehiculosTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
